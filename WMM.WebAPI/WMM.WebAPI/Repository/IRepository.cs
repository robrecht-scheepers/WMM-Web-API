using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WMM.WebAPI.Models;

namespace WMM.WebAPI.Repository
{
    public interface IRepository
    {
        Task<List<Transaction>> GetAllTransactions();
    }
}
