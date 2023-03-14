using System;
using System.Collections.Generic;

namespace Classifier
{
    public class Operand : IMathExpression
    {
        public string Symbol { get; set; }
        public string[] Variables => new string[] { Symbol };
        public int Height => 1;

        public Operand(string symbol)
        {
            Symbol = symbol;
        }

        public double Evaluate(Dictionary<string, double> values)
        {
            return values[Symbol];
        }

        public IEnumerator<IMathExpression> GetEnumerator()
        {
            yield return this;
        }

        public object Clone()
        {
            return new Operand(Symbol);
        }
        public override string ToString()
        {
            return Symbol + " ";
        }
    }
}
