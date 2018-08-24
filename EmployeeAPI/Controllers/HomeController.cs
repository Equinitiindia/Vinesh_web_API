using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeAPI.Controllers
{
    public class HomeController : ApiController
    {

        [HttpPost]
       public bool AddEmpdetails()
        {

            return 1000;


            return true;
        }

        [HttpGet]
        public EmployeeAPI.App_Start.Emp GetEmpdetails()
        {
            return new EmployeeAPI.App_Start.Emp()
            {
                id = "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                ApplicationId = "197104",
                Type = "Debit",
                Summary= "Payment",
                Amount= 58.26,
                PostingDate = "2016 - 07 - 01T00:00:00",
                IsCleared = true,
                ClearedDate = "2016-07-02T00:00:00"
            };
        }

        [HttpDelete]
        public string DeleteEmpdetails(string id)
        {
            return "Deleted Employee "+ id;
        }

        [HttpPut]
        public  string updateEmpdetails(string id, string ApplicationId,string Type,string Summary,float Amount,DateTime PostingDate, string IsCleared, DateTime ClearedDate)
        {
            return "Employee details updated";
        }
    }
}
