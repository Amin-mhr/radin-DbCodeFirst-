using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace University.Db.Model
{
    public class Admin
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Key]
        public string AdminName { get; set; }
    }
}
