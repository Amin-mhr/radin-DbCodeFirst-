using System;
using System.Linq;
using University.Db;

namespace University.Contract.Dto
{
    public class AdminDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AdminName { get; set; }
    }
}
