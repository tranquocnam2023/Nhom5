using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgainTodoList_Nam.Models;

namespace AgainTodoList_Nam.Services
{
    internal class CompletedImp : IService<CCompleted>
    {
        private List<CCompleted> _completed = new List<CCompleted>();
        private List<CWork> _work = new List<CWork>();

        public void create(CCompleted email)
        {
            _completed.Add(email);
        }

        public void delete(CCompleted id)
        {
            throw new NotImplementedException();
        }

        public void SETALL(List<CCompleted> completed)
        {
            this._completed = completed;
        }

        public List<CCompleted> GetAll()
        {
            return _completed;
        }

        public void setAll(List<CWork> completed)
        {
            _work = completed;
        }

        public List<CWork> getall()
        {
            return _work;
        }

        public CCompleted getById(string id)
        {
            throw new NotImplementedException();
        }

    }
}
