using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WMM.WebAPI.Models;
using WMM.WebAPI.Repository;

namespace WMM.WebAPI.Services
{
    public class TransactionService
    {
        private readonly IRepository _repository;

        public TransactionService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Transaction>> Get()
        {
            return await _repository.GetAllTransactions();
        }
    }
}
