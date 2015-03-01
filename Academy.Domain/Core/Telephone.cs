using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Domain.Core
{
    public class Telephone
    {
        public int TelephoneId { get; set; }
        public string AreaCode { get; set; }
        public string Exchange { get; set; }
        public string PhoneNumber { get; set; }
        public string Extension { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    }
}