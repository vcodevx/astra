using System;

namespace Astra.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string  UserName { get; set; }
        public string UserPassword { get; set; }
    }
}