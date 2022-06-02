using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class CalculatorController : Controller{

    public ActionResult Index()
    {
        return View();
    }

    public JsonResult Evaluate(float first, float second, String oper)
    {
        float result = 0;
        switch (oper){
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "/":
                result = first / second;
                break;
            case "*":
                result = first * second;
                break;
        }

        return Json(result);
    }
}