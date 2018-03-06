using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankAccountMVC2
{
    public class AccountModel
    {
        [Key]
        public int AccountID { get; set; }

        public string First { get; set; }
        public string Last{get;set;}
        public int Month { get; set; }
        public int Year { get; set; }
    }
}