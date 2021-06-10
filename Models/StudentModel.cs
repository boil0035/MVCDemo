using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Test Source : https://www.youtube.com/watch?v=phyV-OQNeRM
namespace MVCDemoApp.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public string Course { get; set; }
        public bool IsEnroll { get; set; } = true;
    }

    

}