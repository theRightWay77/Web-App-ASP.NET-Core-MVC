using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public double Index(double a, double b, char op)
        {
            
            if (op == '\0') return a + b;
            if (op == '+')
                return a + b;
            if (op == '-')
                return a - b;
            if (op == '*')
                return a * b;
           

            return 0;
        }

       

    }
}
