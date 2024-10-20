using CafeManager.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManager.DAL.Repositories
{
    public class AccountRepository
    {
        private ManagerCafeContext _managerCafeContext;
        public Account GetOne(string email, string password)
        {
            //khởi tạo 1 vùng ram mới cho biến conect database
            _managerCafeContext = new ManagerCafeContext();
            // trả về 1 account duy nhất : username : email không phân biệt chữ hoa chữ thường , password chuẩn 
            return _managerCafeContext.Accounts.FirstOrDefault(x => x.Email.ToLower() == email.ToLower() && x.Password == password);
        }
    }
}
