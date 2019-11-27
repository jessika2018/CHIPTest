using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHIPTest.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public string  Type { get; set; }
        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

    }
}
