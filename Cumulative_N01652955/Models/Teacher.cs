﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumulative_N01652955.Models
{
    public class Teacher
    {
        //class which describes what a teacher is

        public int TeacherId { get; set; }
        public string TeacherFName { get; set; }
        public string TeacherLName { get; set; }
        public string EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        //FK ClassId
        public int ClassId { get; set; }
        public Classes Classes { get; set; }

        /*//for just gettng a date
        public string HireDateFormatted => HireDate.ToString("yyyy-MM-dd");*/

    }
}