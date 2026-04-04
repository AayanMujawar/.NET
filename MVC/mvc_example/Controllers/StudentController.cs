// student controller is responsible for handling requests related to students
// it will have actions for listing students, creating a new student, etc.
//its brain is the student repository which will handle the data access logic
// connects model and view together
using mvc_example.Models;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        // Create a list of students
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", Email = "john@example.com" },
            new Student { Id = 2, Name = "Jane Smith", Email = "jane@example.com" }
        };

        // Pass data to the view
        return View(students);
    }
}