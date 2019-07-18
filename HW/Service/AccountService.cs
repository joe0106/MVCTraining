using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HW.Models;
using HW.Models.ViewModels;
using HW.Repository;

namespace HW.Service
{    
    public class AccountService
    {
        private readonly IRepository<AccountBook> _abRepository;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _abRepository = new Repository<AccountBook>(unitOfWork);
        }

        public IEnumerable<RecordsViewModel> Lookup()
        {
            List<AccountBook> results = new List<AccountBook>();
            var source = _abRepository.LookupAll();

            var result = source.Select(acc => new RecordsViewModel()
            {
                Category = acc.Categoryyy.ToString(),
                Price    = acc.Amounttt,
                BuyDate  = acc.Dateee,
                Remarks  = acc.Remarkkk,
            });
            return result;
        }
    }
}