using System;
using System.Collections.Generic;

namespace Clasificare
{
    public interface IMathExpression : ICloneable
    {
        string Symbol { get; set; }
        string[] Variables { get; }
        int Height { get; }

        double Evaluate(Dictionary<string, double> values);

        IEnumerator<IMathExpression> GetEnumerator();
    }
}