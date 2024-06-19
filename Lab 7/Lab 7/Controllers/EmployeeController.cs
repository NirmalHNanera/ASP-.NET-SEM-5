using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Lab_7.Models;

public class EmployeeController : Controller
{
    private static List<EmployeeModel> employeeModels = new List<EmployeeModel>
    {
        new EmployeeModel { Id = 1, Name = "John Doe", Position = "Manager", Salary = 50000 },
        new EmployeeModel { Id = 2, Name = "Jane Smith", Position = "Developer", Salary = 40000 },
        new EmployeeModel { Id = 3, Name = "Michael Johnson", Position = "Designer", Salary = 35000 }
    };

    public IActionResult EmployeeList()
    {
        return View(employeeModels);
    }

    [HttpPost]
    public IActionResult Save(EmployeeModel employeeModel)
    {

        if (employeeModel.Id == 0)
        {
            employeeModel.Id = employeeModels.Count + 1;
            employeeModels.Add(employeeModel);
        }
        else
        {
            EmployeeModel existingEmployeeModel = employeeModels.FirstOrDefault(e => e.Id == employeeModel.Id);
            if (existingEmployeeModel != null)
            {
                existingEmployeeModel.Name = employeeModel.Name;
                existingEmployeeModel.Position = employeeModel.Position;
                existingEmployeeModel.Salary = employeeModel.Salary;
            }
        }
        return RedirectToAction("EmployeeList");
    }

    
    public IActionResult Delete(int id)
    {
        EmployeeModel employeeModel = employeeModels.FirstOrDefault(e => e.Id == id);
        if (employeeModel != null)
        {
            employeeModels.Remove(employeeModel);
        }
        return RedirectToAction("EmployeeList");
    }

    [HttpPost]
    public IActionResult DeleteMany(List<int> idsToDelete)
    {
        if (idsToDelete != null)
        {
            employeeModels = employeeModels.Where(e => !idsToDelete.Contains(e.Id)).ToList();
        }
        return RedirectToAction("EmployeeList");
    }

    // GET action to display the edit form with pre-filled data
    public IActionResult Edit(int id)
    {
        EmployeeModel employeeModel = employeeModels.FirstOrDefault(e => e.Id == id);
        if (employeeModel == null)
        {
            return NotFound();
        }
        ViewBag.Id = employeeModel.Id;
        ViewBag.Name = employeeModel.Name;
        ViewBag.Position = employeeModel.Position;
        ViewBag.Salary = employeeModel.Salary;


        // Pass the employee model to the view for editing
        return View("EmployeeList", employeeModels);
    }
}
