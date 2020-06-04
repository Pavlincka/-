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
    public partial class Доходы : Form
    {
        DB db;
        public Доходы(DB db)
        {
            InitializeComponent();
            this.db = db;
            comboBox1.DataSource = db.статья_Доходжовs;
            comboBox1.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                return;
            Доход доход = new Доход();
            доход.date = dateTimePicker1.Value;
            доход.summa = Convert.ToDouble(textBox1.Text);
            Статья_доходжов статья = (Статья_доходжов)comboBox1.SelectedItem;
            доход.статья = статья;
            db.доходs.Add(доход);
            db.Balance += доход.summa;
            db.Save();
            Close();
        }
    }
}
