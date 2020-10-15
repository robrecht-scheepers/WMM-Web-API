using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMM.WebAPI.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Category Category { get; set; }
        public double Amount { get; set; }
        public string Comments { get; set; }
    }
}
