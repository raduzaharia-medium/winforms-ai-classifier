using System;
using System.Collections.Generic;

namespace Clasificare
{
    public class Individual : IComparable<Individual>, ICloneable
    {
        private double? fitness;

        public IMathExpression MathExpression { get; set; }

        public double Fitness
        {
            get
            {
                if (fitness.HasValue == false)
                {
                    fitness = 0;

                    foreach (var element in RandomGenerator.Data)
                    {
                        double rezultat = Evaluate(element);

                        rezultat = Math.Abs(rezultat - element["result"]);
                        if (double.IsNaN(rezultat) || double.IsInfinity(fitness.Value)) rezultat = 100;

                        fitness += rezultat;
                    }

                    if (double.IsNaN(fitness.Value) || double.IsInfinity(fitness.Value)) fitness = 100000;
                    fitness += Math.Abs(RandomGenerator.Data[0].Keys.Count - 1 - MathExpression.Variables.Length) * 1000;                  // trebuie sa am noua variabile

                    if (MathExpression.Height > RandomGenerator.MaximumHeight) fitness *= 1 + Math.Abs(MathExpression.Height - RandomGenerator.MaximumHeight);
                }

                return fitness.Value;
            }
        }

        public Individual(IMathExpression setMathExpression)
        {
            MathExpression = setMathExpression;
        }
        public Individual(int minHeight, int maxHeight) : this(null)
        {
            MathExpression = RandomGenerator.GenerateRandomExpression(minHeight, maxHeight);
        }

        public Individual Mutation(double probability)
        {
            var result = (Individual)Clone();
            var enumerator = result.MathExpression.GetEnumerator();
            var maxHeight = result.MathExpression.Height;

            foreach (var element in result.MathExpression)
            {
                if (RandomGenerator.Generator.NextDouble() < probability)
                {
                    if (element is Operand) element.Symbol = RandomGenerator.GetRandomOperand().Symbol;
                    else if (element is UnaryOperator) ((UnaryOperator)element).Operand = RandomGenerator.GenerateRandomExpression(1, maxHeight);
                    else
                    {
                        ((BinaryOperator)element).First = RandomGenerator.GenerateRandomExpression(1, maxHeight);
                        ((BinaryOperator)element).Second = RandomGenerator.GenerateRandomExpression(1, maxHeight);
                    }

                    break;
                }
            }

            return result;
        }
        public Individual Cross(Individual parent, double selectionProbability)
        {
            var child1 = (Individual)Clone();
            var child2 = (Individual)parent.Clone();
            var child1Enumerator = child1.MathExpression.GetEnumerator();
            var child2Enumerator = child2.MathExpression.GetEnumerator();

            child1Enumerator.MoveNext();
            child2Enumerator.MoveNext();

            while (RandomGenerator.Generator.NextDouble() > selectionProbability)
            {
                child1Enumerator.MoveNext();
            }
            while (RandomGenerator.Generator.NextDouble() > selectionProbability)
            {
                child2Enumerator.MoveNext();
            }

            if (child1Enumerator.Current is Operand && child2Enumerator.Current is Operand)
            {
                var temp = child1Enumerator.Current.Symbol;

                child1Enumerator.Current.Symbol = child2Enumerator.Current.Symbol;
                child2Enumerator.Current.Symbol = temp;
            }
            else if (child1Enumerator.Current is UnaryOperator && child2Enumerator.Current is Operand) ((UnaryOperator)child1Enumerator.Current).Operand = child2Enumerator.Current;
            else if (child2Enumerator.Current is UnaryOperator && child1Enumerator.Current is Operand) ((UnaryOperator)child2Enumerator.Current).Operand = child1Enumerator.Current;
            else if (child1Enumerator.Current is UnaryOperator && child2Enumerator.Current is UnaryOperator)
            {
                var temp = ((UnaryOperator)child1Enumerator.Current).Operand;

                ((UnaryOperator)child1Enumerator.Current).Operand = ((UnaryOperator)child2Enumerator.Current).Operand;
                ((UnaryOperator)child2Enumerator.Current).Operand = temp;
            }
            else if (child1Enumerator.Current is BinaryOperator && child2Enumerator.Current is UnaryOperator)
            {
                if (RandomGenerator.Generator.NextDouble() < 0.5)
                {
                    var temp = ((BinaryOperator)child1Enumerator.Current).First;

                    ((BinaryOperator)child1Enumerator.Current).First = ((UnaryOperator)child2Enumerator.Current).Operand;
                    ((UnaryOperator)child2Enumerator.Current).Operand = temp;
                }
                else
                {
                    var temp = ((BinaryOperator)child1Enumerator.Current).Second;

                    ((BinaryOperator)child1Enumerator.Current).Second = ((UnaryOperator)child2Enumerator.Current).Operand;
                    ((UnaryOperator)child2Enumerator.Current).Operand = temp;
                }
            }
            else if (child2Enumerator.Current is BinaryOperator && child1Enumerator.Current is UnaryOperator)
            {
                if (RandomGenerator.Generator.NextDouble() < 0.5)
                {
                    var temp = ((BinaryOperator)child2Enumerator.Current).First;

                    ((BinaryOperator)child2Enumerator.Current).First = ((UnaryOperator)child1Enumerator.Current).Operand;
                    ((UnaryOperator)child1Enumerator.Current).Operand = temp;
                }
                else
                {
                    var temp = ((BinaryOperator)child2Enumerator.Current).Second;

                    ((BinaryOperator)child2Enumerator.Current).Second = ((UnaryOperator)child1Enumerator.Current).Operand;
                    ((UnaryOperator)child1Enumerator.Current).Operand = temp;
                }
            }

            return RandomGenerator.Generator.NextDouble() < 0.5 ? child1 : child2;
        }

        public double Evaluate(Dictionary<string, double> values)
        {
            return MathExpression.Evaluate(values);
        }
        public int CompareTo(Individual other) => Fitness.CompareTo(other.Fitness);

        public object Clone()
        {
            return new Individual((IMathExpression)MathExpression.Clone());
        }
    }
}