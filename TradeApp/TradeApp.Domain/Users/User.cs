using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TradeApp.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

       [Required]
        public string Lastname { get; set; }

        public string Email { get; set; }
    }
}
