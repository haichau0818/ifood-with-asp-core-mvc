using ifood_core_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using ifood_core_mvc.Data;
using Microsoft.EntityFrameworkCore;
using ifood_core_mvc.DesignParttern.Interfaces;
using ifood_core_mvc.DesignParttern.UnitOfWork;

namespace ifood_core_mvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly MyDBContext _myDBContext;

        private readonly IUnitOfWork _unitOfWork;


        public EmployeeController(MyDBContext myDBContext, IUnitOfWork unitOfWork)
        {
            this._myDBContext = myDBContext;
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var employees = await _unitOfWork.EmployeeRepository.GetAllData();

            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee model) {

            var Employee = new Employee()
            {
                Id = new Guid(),
                Name = model.Name,
                Email = model.Email,
                DayofBird = model.DayofBird,
                Department = model.Department,
                Salary = model.Salary,
                Phone = model.Phone,

            };

            await _unitOfWork.EmployeeRepository.Insert(Employee);
            await _unitOfWork.CompleteAsync();
            return RedirectToAction("Index");
        }
    }
}
