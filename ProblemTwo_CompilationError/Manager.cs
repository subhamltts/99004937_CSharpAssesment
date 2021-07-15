﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class Manager
    {
        public List<Employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(List<Employee> drEmployeesLst, string cCode) :base(eID, eName, eLevel, eDoJ)
        {
            DirectReports = drEmployeesLst;
            CostCode = cCode;

        }

        public List<string> GetMyReports()
        {
            return DirectReports.Select(x => x.EmpName).ToList();
        }

    }
}
