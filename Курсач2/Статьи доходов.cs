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
    public partial class Статьи_доходов : Form
    {
        DB db;
        public Статьи_доходов(DB dB)
        {
            InitializeComponent();
            db = dB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Статья_доходжов статья = new Статья_доходжов { Name = textBox1.Text };
            db.статья_Доходжовs.Add(статья);
            db.Save();
            Close();
        }
    }
}
