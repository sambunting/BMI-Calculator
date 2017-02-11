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
            int height = Convert.ToInt32(textHeight.Text);
            int weightSt = Convert.ToInt32(textWeightSt.Text);
            double weightLb = Convert.ToDouble(textWeightLb.Text);

            BMI Patient_1 = new BMI(name, height, weightSt, weightLb);

            MessageBox.Show("Name: " + Patient_1.getName() + Environment.NewLine + "Height: " + Patient_1.getHeight() + Environment.NewLine + "Weight: " + Patient_1.getWeight() + Environment.NewLine + "BMI :" + Patient_1.calculateBMIValue() + Environment.NewLine + "You are " + Patient_1.calculateBMI());
       }
    }
}
