using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBoFv2.Models
{
    public class User

    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailReg { get; set; }
        public int? RoleId { get; set; }// M
        //public Role Role { get; set; }// M
    }
    //public class Role //Mfull class
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public List<User> Users { get; set; }
    //    public Role()
    //    {
    //        Users = new List<User>();
    //    }
    //}
}
