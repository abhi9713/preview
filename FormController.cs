using Abhishek_Lodhi.Data;
using Abhishek_Lodhi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Abhishek_Lodhi.Controllers
{
    public class FormController : Controller
    {
        private static List<DynamicForm> Forms = new();
        private readonly AppDbContext _context;

        public FormController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyForm()
        {
            return View();
        }


        [HttpPost]
        public IActionResult MyForm(DynamicForm form)
        {
            if (form == null || form.Fields == null || !form.Fields.Any())
            {
                ModelState.AddModelError("", "The form cannot be empty.");
                return View(form);
            }
            //foreach (var field in form.Fields)
            //{
            //    if (field.FieldType == "checkbox")
            //    {
            //        // Concatenate checkbox values as a single string
            //        field.SelectedOption = string.Join(",", field.Options.Where(o => !string.IsNullOrWhiteSpace(o)));
            //    }
            //}


            // Save to the database
            _context.Forms.Add(form);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Test()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult SaveForm([FromBody] DynamicForm form)
        {
            if (form == null || form.Fields == null || !form.Fields.Any())
            {
                return BadRequest("Invalid form data.");
            }

            _context.Forms.Add(form);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
