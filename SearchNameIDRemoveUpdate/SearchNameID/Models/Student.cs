using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNameID.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }
        public string PhoneNumber { get; set; }
        public double GPA { get; set; }
        public string Status{ get; set; }  // grdadute pending activ removed
        public string Major {  get; set; }
    }
}
