using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgainTodoList_Nam.Models;

namespace AgainTodoList_Nam.Services
{
    internal class WorkImp :IService<CWork>
    {
        private List<CWork> workList = new List<CWork>();

        public void create(CWork email)
        {
            workList.Add(email); 
        }

        public void delete(CWork id)
        {
            workList.Remove(id);
        }

        public List<CWork> GetAll()
        {
            return workList;
        }

        public CWork getById(string id)
        {
            //foreach (CWork item in workList)
            //{
            //    if (item.Id == id)
            //    {
            //        return item;
            //    }
            //}
            return null;
        }

        public void setAll(List<CWork> workList)
        {
            this.workList = workList;
        }

        public List<CWork> getByCode(string code)
        {

            foreach (CWork item in workList)
            {
                if (item.Name == code)
                {
                    return workList.Where(name => name.Name.Contains(code)).ToList();
                }
            }
            return null;
        }
    }
}
