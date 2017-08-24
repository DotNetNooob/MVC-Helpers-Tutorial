using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MVC_Helpers_Tutorial.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }

        //public int? ImageId { get; set; }
        public byte[] DisplayImage { get; set; }
    }
}