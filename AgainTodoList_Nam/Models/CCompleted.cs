using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgainTodoList_Nam.Models
{
    [Serializable]

    internal class CCompleted:CWork
    {
        private DateTime _end;
        public static List<CWork> listCompletedWork = new List<CWork>();

        public DateTime END
        {
            get { return _end; }
            set { _end = value; }
        }
    }
}
