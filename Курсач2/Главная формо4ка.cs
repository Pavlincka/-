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
    public partial class Form1 : Form
    {
        DB db = new DB();
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            show();
            show2();

        }

        void show()
        {
            listView1.Items.Clear();
            foreach (Расход расход in db.расходs)
            {

                
                    ListViewItem type1 = new ListViewItem(расход.date.ToShortDateString());

                    type1.SubItems.Add(расход.summa.ToString());
                    type1.SubItems.Add(расход.статьйа.Name);
                    type1.Tag = расход;
                    listView1.Items.Add(type1);
            }
        }

        void show2()
        {
            listView2.Items.Clear();
            foreach (Доход доход in db.доходs)
            {


                ListViewItem type1 = new ListViewItem(доход.date.ToShortDateString());

                type1.SubItems.Add(доход.summa.ToString());
                type1.SubItems.Add(доход.статья.Name);
                type1.Tag = доход;
                listView2.Items.Add(type1);
            }
        }

        private void внестиДоходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Доходы(db).Show();
        }

        private void внестиРасходыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Расходы(db).Show();
        }

        private void текущийБалансToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Текущийбаланс(db).Show();
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Отчет(db).Show();
        }

        private void доходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Статьи_доходов(db).Show();
        }

        private void расходовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Статьи_расхордов(db).Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                show();
            show2();
            db.Save(); 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Save();
        }

    }
}
