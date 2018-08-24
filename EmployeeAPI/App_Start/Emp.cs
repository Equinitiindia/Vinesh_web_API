using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeAPI.App_Start
{
    public class Emp
    {
        public string id { get; set; } 
        public string ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public double Amount { get; set; }
        public string PostingDate { get; set; }
        public Boolean IsCleared { get; set; }
        public string ClearedDate { get; set; }
    }
}