using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    [Table("User")]
    public class User : BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int PhoneNr { get; set; }
    }
}
