﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem_Gurlove_09.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<EmployeeDetail> EmployeeDetail { get; set; }
    }
}
