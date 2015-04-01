using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class LeaveAskRequest
    {
        /// <summary>
        /// 请假天数
        /// </summary>
        public int Days { get; set; }
        /// <summary>
        /// 请假人
        /// </summary>
        public string RequestName { get; set; }

        public LeaveAskRequest(string name,int days)
        {
            this.RequestName = name;
            this.Days = days;
        }
    }
}
