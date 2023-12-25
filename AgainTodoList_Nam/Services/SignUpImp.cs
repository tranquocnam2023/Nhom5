using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainTodoList_Nam.Models;

namespace AgainTodoList_Nam.Services
{
    internal class SignUpImp : IService<CSignUp>
    {
        List<CSignUp> signUpList = new List<CSignUp>();

        public void create(CSignUp email)
        {
            signUpList.Add(email);
        }

        public void delete(CSignUp id)
        {
            throw new NotImplementedException();
        }

        public List<CSignUp> GetAll()
        {
            return signUpList;
        }

        public CSignUp getById(int id)
        {
            throw new NotImplementedException();
        }

        public CSignUp getById(string id)
        {
            throw new NotImplementedException();
        }

        public void setAll(List<CSignUp> signUpList)
        {
            this.signUpList = signUpList;
        }
    }
}
