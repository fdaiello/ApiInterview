using System.Diagnostics.Eventing.Reader;
using System.Numerics;

namespace ApiInterview.Services
{
    public class Operator
    {
        public string Calculate(string operation, long left, long right )
        {
            return operation switch
            {
                "multiplication" => ((BigInteger)left * right).ToString(),
                "division" => ((decimal)left / (decimal)right).ToString(),
                "subtraction" => (left - right).ToString(),
                "addition" => (left + right).ToString(),
                "remainder" => (left % right).ToString(),
                _ => "0",
            };
        }

    }
}
