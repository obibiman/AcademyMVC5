using System;

namespace Academy.Domain.Core
{
    public class Email
    {
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<DateTime> ModifiedDate { get; set; }
    }
}