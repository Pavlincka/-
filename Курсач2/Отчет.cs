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
    public partial class Отчет : Form
    {
        DB db;
        public Отчет(DB db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            DateTime dateTime2 = dateTimePicker2.Value;
            new Итоговый_отчет(db, dateTime, dateTime2).Show();

        }


    }
}
