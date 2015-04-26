using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_update
{
    public partial class Form1 : Form
    {
        public List<string> lang = new List<string> { "en", "fr", "de", "es","it" };

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //se accepta doar cifre + copy, cut, paste, select all, etc.
            e.Handled = !("0123456789".Contains(e.KeyChar)) && !(char.IsControl(e.KeyChar));
        }
    }
}
