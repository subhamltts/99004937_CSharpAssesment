using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using employee;

namespace manager
{
    public class Manager
    {
        public List<employee> DirectReports { get; set; }
        public string CostCode { get; set; }

        public Manager(List<employee> drEmployeesLst, string cCode) : base(eID, eName, eLevel, eDoJ)
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
