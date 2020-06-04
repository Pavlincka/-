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
    public partial class Расходы : Form
    {
        DB db;
        public Расходы(DB db)
        {
            InitializeComponent();
            this.db = db;
            comboBox1.DataSource = db.статьи_Расхордовs;
            comboBox1.DisplayMember = "Name";
        }

        private void Расходы_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Расход расход = new Расход();
            расход.date = dateTimePicker1.Value;
            расход.summa = Convert.ToDouble(textBox1.Text);
            Статья_расходов статья = (Статья_расходов)comboBox1.SelectedItem;
            расход.статьйа = статья;
            db.расходs.Add(расход);
            db.Balance -= расход.summa;
            db.Save();
            Close();
        }
    }
}
