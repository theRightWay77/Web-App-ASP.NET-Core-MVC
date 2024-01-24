using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        // GET: CalculatorController
        public string Index(string a, string b, string c)
        {
            if(! double.TryParse(a ?? "0", out double num1) || !double.TryParse(b ?? "0", out double num2))
                { return "Неверный формат введенных данный, будьте внимательней"; }
            if(! char.TryParse(c ?? "+", out var operat))
                { return "Такого оператора не существует, или его нельзя передать"; }

            switch (c)
            {
                case "+": return $"{a} {c} {b} = {num1 + num2}";
                case "-": return $"{a} {c} {b} = {num1 - num2}";
                case "*": return $"{a} {c} {b} = {num1 * num2}";
                case "/": return $"{a} {c} {b} = {num1 / num2}";
                default: return "Такого оператора не существует, можно использовать +,-,*,/";
            }

         
        }

       

    }
}
