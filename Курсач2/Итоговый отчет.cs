using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач2
{
    public partial class Итоговый_отчет : Form
    {
        public Итоговый_отчет(DB db, DateTime dateTime, DateTime dateTime2)
        {
            double d = 0;
            double x = 0;
            InitializeComponent();
            foreach (var a in db.доходs.Where(s => s.date >= dateTime && s.date <= dateTime2))
            {
                
                d += a.summa;
                
            }



            foreach (var a in db.расходs.Where(s => s.date >= dateTime && s.date <= dateTime2))
            {
                
                x += a.summa;
                
            }

            textBox1.Text = d.ToString();
            textBox2.Text = x.ToString();
        }
    }
}
