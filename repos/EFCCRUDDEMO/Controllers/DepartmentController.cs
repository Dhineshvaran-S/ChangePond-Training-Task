using EFCCRUDDEMO.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCCRUDDEMO.Controllers
{
    public class DepartmentController : Controller
    {
        private CompanyContext context;
        public DepartmentController(CompanyContext cC)
        {
            context = cC;
        }
        public IActionResult Create()
        {
            //    //var dept1 = new Department()
            //    //{
            //    //    Name = "Development"
            //    //};

            //    //var dept2 = new Department()
            //    //{
            //    //    Name = "Design"
            //    //};

            //    //var dept3 = new Department()
            //    //{
            //    //    Name = "Devops"
            //    //};
            //    //var dept4 = new Department()
            //    //{
            //    //    Name = "Development"
            //    //};

            //    //context.AddRange(dept1,dept2,dept3,dept4);
            //    //context.SaveChanges();

            //    // return "Department Added";
            return View();


        }
        [HttpPost]

        public async Task<IActionResult> Create(Department dept)
        {
            context.Add(dept);
            await context.SaveChangesAsync();
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            Department dept = await context.Department.Where(e => e.Id == id).FirstOrDefaultAsync();

            return View(dept);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(Department dept)
        {
            context.Update(dept);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View(context.Department.AsNoTracking());
        }


        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var emp = new Department() { Id = id };
            context.Remove(emp);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}