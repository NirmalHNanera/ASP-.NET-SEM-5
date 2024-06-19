using Lab_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lsb_5.Controllers;

public class CalculatorController : Controller
{
    public IActionResult Calculator(CalculatorModel model)
    {
        switch (model.operation)
        {
            case "Add":
                model.result = model.number1 + model.number2;
                break;
            case "Subtract":
                model.result = model.number1 - model.number2;
                break;
            case "Multiply":
                model.result = model.number1 * model.number2;
                break;
            case "Divide":
                model.result = model.number2 != 0 ? model.number1 / model.number2 : 0;
                break;
        }

        return View(model);
    }
}