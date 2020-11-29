using Microsoft.AspNetCore.Mvc;
using NewBrandingStyle.Web.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBrandingStyle.Web.Components
{
    public class LatestItem : ViewComponent
    {
        private readonly ExchangesDbContext dbContex;

        public LatestItem(ExchangesDbContext dbContex)
        {
            this.dbContex = dbContex;
        }

        public IViewComponentResult Invoke()
        {
            var lastItem = dbContex.Items.OrderByDescending(x => x.Id).First();
            return View(lastItem);
        }
    }
}
