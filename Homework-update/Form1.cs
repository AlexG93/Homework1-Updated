using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Humanizer;

namespace Homework_update
{
    public partial class Form1 : Form
    {
        public List<string> language = new List<string> { "en", "fr", "de", "es","it" };

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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //se poate da copy-paste doar la numere intregi
            if (e.Control && e.KeyCode == Keys.V)
            {
                int result;
                if (!Int32.TryParse(Clipboard.GetText(), out result))
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (Int32.TryParse(textBox1.Text,out number))
            {
                string result = number.ToWords(new System.Globalization.CultureInfo(language[comboBox1.SelectedIndex]));
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show("Enter a digit!");
            }
 
        }        
    }
        }
    

