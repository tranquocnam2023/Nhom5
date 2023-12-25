using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgainTodoList_Nam.FileSave
{
    internal class FileFactory<T>
    {

        public bool SaveFile(List<T> list, string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, list);
            fs.Close();
            return true;
        }

        public List<T> LoadFile(string path)
        {
            List<T> list = new List<T>();
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            list =data as List<T>;
            fs.Close();
            return list;
        }

        public List<T> LoadFileCompleted(string path)
        {
            List<T> list;
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            object data = bf.Deserialize(fs);
            list =data as List<T>;
            fs.Close();
            return list;
        }

    }
}
