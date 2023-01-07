using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeogProjects.Models
{
    public class Service
    {
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public bool Status { get; set; }
    }
}