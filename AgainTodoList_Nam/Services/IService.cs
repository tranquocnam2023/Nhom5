using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainTodoList_Nam.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        T getById(string id);
        void create(T email);
        void delete(T id);
    }
}
