using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class CongViec 
    {
        private int _id;
        private string _tieude;
        private DateTime _time;

        #region Property

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _tieude; }
            set { _tieude = value; }
        }

        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }

        #endregion

        #region Contructor

        public CongViec() {
            this._id = 0;
            this._tieude = string.Empty;
            this._time = new DateTime();
        }

        public CongViec(int id,string name,DateTime time)
        {
            _id = id;
            _tieude = name;
            _time = time;
        }

        #endregion

        #region method

        //public override string ToString()
        //{
        //    return ID+" _ " + Name +" _ "+Time;
        //}

        #endregion
    }
}
