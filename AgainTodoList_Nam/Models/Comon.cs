using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AgainTodoList_Nam.Models
{
    [Serializable]
    internal class Comon
    {
        private string email;
        private string pass;

        public string EMAIL { get { return this.email; } set { this.email=value; } }

        public string PASS
        {
            get { return this.pass; }
            set { this.pass=value; }
        }

        public override string ToString()
        {
            return EMAIL;
        }
    }
}
