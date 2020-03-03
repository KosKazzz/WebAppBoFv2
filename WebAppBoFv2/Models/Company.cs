using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBoFv2.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Org_name { get; set; }
        public string Region { get; set; }
        public ulong INN { get; set; }
        public ulong KPP { get; set; }
        public ulong OGRN { get; set; }
        public ulong Account_number { get; set; }
        public string Org_phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Org_email { get; set; }
        public string Info { get; set; }
        
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
