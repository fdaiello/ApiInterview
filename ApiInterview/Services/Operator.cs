using System.Diagnostics.Eventing.Reader;

namespace ApiInterview.Services
{
    public class Operator
    {
        public long Calculate(string operation, long left, long right )
        {
            return operation switch
            {
                "multiplication" => left * right,
                "division" => left / right,
                "subtraction" => left - right,
                "addition" => left + right,
                "remainder" => left % right,
                _ => 0,
            };
        }

    }
}
