//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DevPioneers.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER_DEFINTIONS
    {
        public USER_DEFINTIONS()
        {
            this.ITEMS = new HashSet<ITEM>();
            this.USER_SECURITY_LIST = new HashSet<USER_SECURITY_LIST>();
        }
    
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool ACTIVE_IND { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> USER_GROUP_ID { get; set; }
        public Nullable<int> COMPANY_ID { get; set; }
        public int LANGUAGE_ID { get; set; }
        public string ADDRESS_1 { get; set; }
        public string ADDRESS_2 { get; set; }
        public string CONTACT_NO { get; set; }
        public string POSTAL_CODE { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string CITY { get; set; }
    
        public virtual COMPANY COMPANY { get; set; }
        public virtual ICollection<ITEM> ITEMS { get; set; }
        public virtual USER_GROUPS USER_GROUPS { get; set; }
        public virtual ICollection<USER_SECURITY_LIST> USER_SECURITY_LIST { get; set; }
    }
}
