namespace Academy.Domain.Core
{
    public class ContactInfo
    {
        public int ContactInfoId { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int EmailId { get; set; }
        public virtual Email Email { get; set; }
        public int TelephoneId { get; set; }
        public virtual Telephone Telephone { get; set; }  
    }
}