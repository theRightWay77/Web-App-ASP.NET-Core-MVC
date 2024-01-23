using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public int Index(int a, int b)
        {
            return a + b;
        }

    }
}
