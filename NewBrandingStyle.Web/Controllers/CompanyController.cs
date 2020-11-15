using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using NewBrandingStyle.Web.Models;
using NewBrandingStyle.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ExchangesDbContext _dbContext;


        public CompanyController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            var model = new CompanyAddViewModel()
            {
                NumberOfCharsInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                isHidden = !company.isVisible
            };

            var item = new ItemEntity()
            {
                Id = Guid.NewGuid().ToString(),
                Name = company.Name,
                Description = company.Description,
                isVisible = company.isVisible
            };

            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();

            model.Items = _dbContext.Items.ToList();


            return View("Company Added", model);
        }

    }
}
