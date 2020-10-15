using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMM.WebAPI.Models
{
    public class Category
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public CategoryType Type { get; set; }
        public Area Area { get; set; }
    }
}
