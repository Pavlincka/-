using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Курсач2
{
    public class DB
    {
        public List<Доход> доходs = new List<Доход>();
        public List<Расход> расходs = new List<Расход>();

        public List<Статья_доходжов> статья_Доходжовs = new List<Статья_доходжов>();
        public List<Статья_расходов> статьи_Расхордовs = new List<Статья_расходов>();

        public double Balance = 0;

        static BinaryFormatter BF = new BinaryFormatter();

        public DB()
        {
            if (!File.Exists("db.db"))
                return;
            using (FileStream fs = new FileStream("db.db", FileMode.Open, FileAccess.Read))
            {
                доходs = ((List<Доход>)BF.Deserialize(fs));
                расходs = ((List<Расход>)BF.Deserialize(fs));
                статьи_Расхордовs = ((List<Статья_расходов>)BF.Deserialize(fs));
                статья_Доходжовs = ((List<Статья_доходжов>)BF.Deserialize(fs));

                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                Balance = BitConverter.ToInt32(array, 0);
            }
        }
        public void Save()
        {
            using (FileStream fs = new FileStream("db.db", FileMode.Create, FileAccess.Write))
            {
                BF.Serialize(fs, доходs);
                BF.Serialize(fs, расходs);
                BF.Serialize(fs, статьи_Расхордовs);
                BF.Serialize(fs, статья_Доходжовs);

                fs.Write(BitConverter.GetBytes(Balance), 0, 4);
            }
        }
    }
}
