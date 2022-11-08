using System;
﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using ContinuedLearning110822.Models;
using ContinuedLearning110822.Data;

namespace ContinuedLearning110822.Controllers
{
	public partial class GridController : Controller
    {
        private readonly Data.NorthwindEntities _northwindEntities = new NorthwindEntities();

        

        public ActionResult GetCustomers([DataSourceRequest] DataSourceRequest request)
        {
            var result = _northwindEntities.Customers.Select(c=> new CustomerModel()
            {
                CustomerID = c.CustomerID,
                CustomerName = c.CustomerName,
                ContactName = c.ContactName,
                Address = c.Address,
                City = c.City,
                Country = c.Country,
                PostalCode = c.PostalCode
            });


            return Json(result.ToDataSourceResult(request));
        }


    }
}
