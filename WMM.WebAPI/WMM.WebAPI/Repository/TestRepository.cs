using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMM.WebAPI.Models;

namespace WMM.WebAPI.Repository
{
    public class TestRepository : IRepository
    {
        private static Area _area1 = new Area { Id = "a1", Name = "Area 1" };
        private static Area _area2 = new Area { Id = "a2", Name = "Area 2" };
        private static Category _category1 = new Category { Id = "c1", Name = "Category 1", Area = _area1, Type = CategoryType.Daily };
        private static Category _category2 = new Category { Id = "c2", Name = "Category 2", Area = _area1, Type = CategoryType.Monthly };
        private static Category _category3 = new Category { Id = "c3", Name = "Category 3", Area = _area2, Type = CategoryType.Exception };
        private static Category _category4 = new Category { Id = "c4", Name = "Category 4", Area = _area2, Type = CategoryType.Recurring };

        private List<Transaction> _testTransactions = new List<Transaction>
        {
            new Transaction{Id = "t1", Category = _category1, Date = new DateTime(2020, 10, 15), Amount = -20.00 },
            new Transaction{Id = "t1", Category = _category1, Date = new DateTime(2020, 10, 15), Amount = -100.00 },
            new Transaction{Id = "t1", Category = _category1, Date = new DateTime(2020, 10, 16), Amount = -13.87 },
            new Transaction{Id = "t1", Category = _category2, Date = new DateTime(2020, 10, 14), Amount = 250.00 },
            new Transaction{Id = "t1", Category = _category2, Date = new DateTime(2020, 10, 15), Amount = -71.65 },
            new Transaction{Id = "t1", Category = _category2, Date = new DateTime(2020, 10, 16), Amount = -88.45 },
            new Transaction{Id = "t1", Category = _category3, Date = new DateTime(2020, 10, 15), Amount = -10.99 },
            new Transaction{Id = "t1", Category = _category3, Date = new DateTime(2020, 10, 16), Amount = -45.00 },
        };

        public Task<List<Transaction>> GetAllTransactions()
        {
            return Task.FromResult(_testTransactions);
        }
    }
}
