using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainTodoList_Nam.Models
{
    [Serializable]

    internal class CWork 
    {
        //private string _id;
        private string _name;
        private DateTime _created;

        //public string Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Created { get { return _created; } set { _created = value; } }

        public CWork() { }
    }
}
