using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBAccess.Entities
{
    internal class OTPLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OTPNumber { get; set; }
        public string IPAddress { get; set; }
        public DateTime createdDatetime { get; set; }
        public int IsSuccessfullLogin { get; set; }
    }
}
