using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectReport
{
    public class DirectReport
    {

        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }

        public DirectReport(Employee managerEmpObj, string pCode) : base(eID, eName, eLevel, eDoJ)
        {
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }
    }
}
