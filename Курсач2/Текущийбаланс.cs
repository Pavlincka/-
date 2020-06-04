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
    public partial class Текущийбаланс : Form
    {

        public Текущийбаланс(DB dB)
        {
            InitializeComponent();

            textBox1.Text = dB.Balance.ToString();
            dB.Save();
        }

    }
}
