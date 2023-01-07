using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeogProjects.Models
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialDescription{ get; set; }
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}