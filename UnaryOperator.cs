using System;
using System.Collections.Generic;

namespace Classifier
{
    public class UnaryOperator : IMathExpression
    {
        private readonly Func<double, double> OperatorFunction;
        private int? height;

        public IMathExpression Operand { get; set; }
        public string Symbol { get; set; }
        public string[] Variables
        {
            get
            {
                var result = new List<string>();

                foreach (var element in Operand.Variables) if (result.Contains(element) == false) result.Add(element);
                return result.ToArray();
            }
        }
        public int Height
        {
            get
            {
                if (height.HasValue == false)
                {
                    height = 1 + Operand.Height;
                }

                return height.Value;
            }
        }

        public UnaryOperator(string symbol, Func<double, double> operatorFunction)
        {
            Symbol = symbol;
            OperatorFunction = operatorFunction;
        }

        public double Evaluate(Dictionary<string, double> values)
        {
            var result = OperatorFunction(Operand.Evaluate(values));
            return result;
        }

        public IEnumerator<IMathExpression> GetEnumerator()
        {
            yield return this;
            foreach (var element in Operand) yield return element;
        }

        public object Clone()
        {
            var result = new UnaryOperator(Symbol, OperatorFunction);

            if (Operand != null) result.Operand = (IMathExpression)Operand.Clone();
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