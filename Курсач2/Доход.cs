using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач2
{
    [Serializable]
    public class Доход
    {
        public DateTime date { get; set; }
        public double summa { get; set; }
        public Статья_доходжов статья { get; set; }
}
}
