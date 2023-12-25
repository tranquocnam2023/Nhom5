using AgainTodoList_Nam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainTodoList_Nam.Services
{
    internal class LoginImp : IService<CLogin>
    {
        List<CLogin> listLogin = new List<CLogin>();

        public void create(CLogin email)
        {
            listLogin.Add(email);
        }

        public void delete(CLogin id)
        {
            throw new NotImplementedException();
        }

        public List<CLogin> GetAll()
        {
            return listLogin;
        }

        public CLogin getById(string id)
        {
            throw new NotImplementedException();
        }

        public void setAll(List<CLogin> list)
        {
            listLogin = list;
        }
    }
}
