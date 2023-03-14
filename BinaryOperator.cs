using System;
using System.Collections.Generic;

namespace Classifier
{
    public class BinaryOperator : IMathExpression
    {
        private readonly Func<Tuple<double, double>, double> OperatorFunction;
        private int? height;

        public string Symbol { get; set; }
        public IMathExpression First { get; set; }
        public IMathExpression Second { get; set; }

        public string[] Variables
        {
            get
            {
                var result = new List<string>();

                foreach (var element in First.Variables) if (result.Contains(element) == false) result.Add(element);
                foreach (var element in Second.Variables) if (result.Contains(element) == false) result.Add(element);

                return result.ToArray();
            }
        }
        public int Height
        {
            get
            {
                if (height.HasValue == false)
                {
                    height = First.Height > Second.Height ? 1 + First.Height : 1 + Second.Height;
                }

                return height.Value;
            }
        }

        public BinaryOperator(string symbol, Func<Tuple<double, double>, double> operatorFunction)
        {
            Symbol = symbol;
            OperatorFunction = operatorFunction;
        }

        public double Evaluate(Dictionary<string, double> values)
        {
            var first = First.Evaluate(values);
            var second = Second.Evaluate(values);
            var result = OperatorFunction(Tuple.Create(first, second));

            return result;
        }

        public IEnumerator<IMathExpression> GetEnumerator()
        {
            yield return this;

            foreach (var element in First) yield return element;
            foreach (var element in Second) yield return element;
        }

        public object Clone()
        {
            var result = new BinaryOperator(Symbol, OperatorFunction);

            if (First != null) result.First = (IMathExpression)First.Clone();
            if (Second != null) result.Second = (IMathExpression)Second.Clone();

            return result;
        }

        public override string ToString()
        {
            var result = string.Empty;

            foreach (var element in this) result += element.Symbol + " ";
            return result;
        }
        public string ToString(Dictionary<string, double> values)
        {
            var result = string.Empty;

            foreach (var element in this)
            {
                if (element is Operand) result += values[element.Symbol] + " ";
                else result += element.Symbol + " ";

            }
            return result;
        }
    }
}