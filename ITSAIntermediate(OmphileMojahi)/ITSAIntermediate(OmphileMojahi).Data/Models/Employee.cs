﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSAIntermediate_OmphileMojahi_.Data.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public Guid UserId { get; set; }
        public string Department { get; set; }
        public string Role { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool Deleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
