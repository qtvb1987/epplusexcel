using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using epplusexcel.BLL;

namespace epplusexcel.Models
{
    public class StudentViewModel
    {
        public List<Student> ListStudent => StaticDataOfStudent.ListStudent;
    }
}