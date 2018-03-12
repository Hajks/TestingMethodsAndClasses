using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingMethodsAndClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Minimalize & Maximized buttons disabled
        //After clicking button, application will display message which user introduced as many times as user want 
        //then will count length of message including spacebars but without enters

        private void button1_Click(object sender, EventArgs e)
        {
            if (numberOfTimesLabel.Value == 0 || numberOfTimesLabel.Value > 10) //I could use min and max value avaiable for NumericUpDown object , but wanted to display message what numbers are allowed here
            {
                MessageBox.Show("Wprowadź liczbę całkowitą od 1 do 10");
            }
            else
            { 
            int x = Talker.BlaBlaBla(textLabel.Text, (int)numberOfTimesLabel.Value);
            MessageBox.Show("Dlugość wiadomości to " + x);
            }
        }
    }
}
