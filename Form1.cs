 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorMachine;

namespace CalculatorWindowsFormAppTantangan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private int Penambahan(int a, int b)
        {
            return a + b;
        }
        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        } */

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            var a = int.Parse(txtNilai1.Text);
            var b = Convert.ToInt32(txtNilai2.Text);

            var cal = new Calculator();

            if (combo1.SelectedIndex == 0)
            {
                txtHasil.Text = Convert.ToString(cal.Penambahan(a, b));
            }
            if (combo1.SelectedIndex == 1)
            {
                txtHasil.Text = Convert.ToString(cal.Pengurangan(a, b));
            }
            if (combo1.SelectedIndex == 2)
            {
                txtHasil.Text = Convert.ToString(cal.Perkalian(a, b));
            }
            if (combo1.SelectedIndex == 3)
            {
                txtHasil.Text = Convert.ToString(Calculator.Pembagian(a, b));
            }
            if (combo1.SelectedIndex == 4)
            {
                txtHasil.Text = Convert.ToString(cal.Pangkat(a, b));
            }
            if(combo1.SelectedIndex == 5)
            {
                txtHasil.Text = Convert.ToString(Calculator.Modulo(a, b));
            }
        }
    }
}
