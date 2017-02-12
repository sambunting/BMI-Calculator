using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string height = textHeight.Text;
            string weightSt = textWeightSt.Text;
            string weightLb = textWeightLb.Text;

            if (String.IsNullOrEmpty(name))
                MessageBox.Show("The name field is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (String.IsNullOrEmpty(height.ToString()))
                MessageBox.Show("The height field is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (String.IsNullOrEmpty(weightSt.ToString()) || String.IsNullOrEmpty(weightLb.ToString()))
                MessageBox.Show("Both weight fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else if (Convert.ToInt32(weightLb) >= 14)
                MessageBox.Show("Invalid pounds value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {
                BMI Patient_1 = new BMI(name, Convert.ToInt32(height), Convert.ToInt32(weightSt), Convert.ToDouble(weightLb));

                string resultString = "Name: " + Patient_1.getName() + Environment.NewLine + "Height: " + Patient_1.getHeight() + Environment.NewLine + "Weight: " + Patient_1.getWeight() + Environment.NewLine + "BMI :" + Patient_1.calculateBMIValue() + Environment.NewLine + "You are " + Patient_1.calculateBMI();

                MessageBox.Show(resultString, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
       }
    }
}
