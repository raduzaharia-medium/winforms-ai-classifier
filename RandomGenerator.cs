using System;
using System.Collections.Generic;
using System.IO;

namespace Classifier
{
    public class RandomGenerator
    {
        private static Lazy<Random> generator = new Lazy<Random>(() => new Random(Guid.NewGuid().GetHashCode()));
        private static Lazy<List<Operand>> operands = new Lazy<List<Operand>>(() => LoadOperands(9));
        private static Lazy<List<IMathExpression>> operators = new Lazy<List<IMathExpression>>(() => LoadOperators());
        private static Lazy<List<Dictionary<string, double>>> data = new Lazy<List<Dictionary<string, double>>>(() => LoadData("cancer.txt"));
        private static Lazy<List<IMathExpression>> expressions = new Lazy<List<IMathExpression>>(() => LoadExpressions());

        public static int MaximumHeight { get; set; }
        public static Random Generator => generator.Value;
        public static List<Operand> Operands => operands.Value;
        public static List<IMathExpression> Operators => operators.Value;
        public static List<Dictionary<string, double>> Data => data.Value;
        public static List<IMathExpression> Expressions => expressions.Value;

        public static IMathExpression GetRandomOperator() => Operators[Generator.Next(Operators.Count)];
        public static Operand GetRandomOperand() => Operands[Generator.Next(Operands.Count)];
        public static IMathExpression GetRandomExpression() => Expressions[Generator.Next(Expressions.Count)];

        public static IMathExpression GenerateRandomExpression(int minHeight, int maxHeight)
        {
            var result = minHeight > 0
                ? (IMathExpression)RandomGenerator.GetRandomOperator().Clone()
                : maxHeight <= 0
                    ? (IMathExpression)RandomGenerator.GetRandomOperand().Clone()
                    : (IMathExpression)RandomGenerator.GetRandomExpression().Clone();

            if (result is Operand) return result;
            else if (result is UnaryOperator) ((UnaryOperator)result).Operand = GenerateRandomExpression(minHeight - 1, maxHeight - 1);
            else
            {
                ((BinaryOperator)result).First = GenerateRandomExpression(minHeight - 1, maxHeight - 1);
                ((BinaryOperator)result).Second = GenerateRandomExpression(minHeight - 1, maxHeight - 1);
            }

            return result;
        }

        private static List<Dictionary<string, double>> LoadData(string fileName)
        {
            var result = new List<Dictionary<string, double>>();

            using (var reader = new StreamReader(fileName))
            {
                var row = string.Empty;

                while ((row = reader.ReadLine()) != null)
                {
                    var components = row.Split(',');
                    var date = new Dictionary<string, double>();

                    foreach (var element in Operands)
                    {
                        date.Add(element.Symbol, double.Parse(components[Operands.IndexOf(element)]));
                    }

                    date.Add("result", double.Parse(components[9]));
                    result.Add(date);
                }
            }

            return result;
        }
        private static List<Operand> LoadOperands(int count)
        {
            var result = new List<Operand>();

            for (int i = 0; i < count; i++)
                result.Add(new Operand(((char)(i + 97)).ToString()));

            return result;
        }
        private static List<IMathExpression> LoadOperators()
        {
            var result = new List<IMathExpression>
            {
                new BinaryOperator("+", tuple => tuple.Item1 + tuple.Item2),
                new BinaryOperator("-", tuple => tuple.Item1 - tuple.Item2),
                new BinaryOperator("*", tuple => tuple.Item1 * tuple.Item2),
                new BinaryOperator("/", tuple => tuple.Item1 / tuple.Item2),
                new UnaryOperator("sin", item => Math.Sin(item)),
                new UnaryOperator("cos", item => Math.Cos(item)),
                new UnaryOperator("sqrt", item => Math.Sqrt(item)),
                new BinaryOperator("pow", tuple => Math.Pow(tuple.Item1, tuple.Item2)),
                new UnaryOperator("ln", item => Math.Log10(item)),
                new UnaryOperator("exp", item => Math.Exp(item))
            };

            return result;
        }
        private static List<IMathExpression> LoadExpressions()
        {
            var result = new List<IMathExpression>();

            result.AddRange(Operands);
            result.AddRange(Operators);

            return result;
        }
    }
}