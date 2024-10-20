using CafeManager.DAL.Models;
using CafeManager.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.BLL.Services
{
    public class AccountService
    {
        private AccountRepository _accountRepository = new();
        public Account? Authenticate(string email, string password)
        {
            return _accountRepository.GetOne(email, password);
        }
    }
}
