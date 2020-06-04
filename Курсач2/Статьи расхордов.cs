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
    public partial class Статьи_расхордов : Form
    {
        DB db;
        public Статьи_расхордов(DB dB)
        {
            InitializeComponent();
            db = dB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Статья_расходов статьи = new Статья_расходов { Name = textBox1.Text };
            db.статьи_Расхордовs.Add(статьи);
            db.Save();
            Close();
        }


    }
}
