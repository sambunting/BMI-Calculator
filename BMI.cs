using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    class BMI
    {
        // Default Constructor
        public BMI()
        {
            newName = "";
            newHeight = 0;
            newWeightSt = 0;
        }

        // Overload Constructor
        public BMI(string name, int height, int weightSt, double weightLb)
        {
            newName = name;
            newHeight = height;
            newWeightSt = weightSt;
            newWeightLb = weightLb;
        }

        // Accessor Functions
        public string getName()
        {
            return newName;
        }

        public int getHeight()
        {
            return newHeight;
        }

        public string getWeight()
        {
            return Convert.ToString(newWeightSt) + "st " + Convert.ToString(newWeightLb) + "lb";
        }

        // Mutator Functions
        public double calculateBMIValue()
        {
            //Convert Stones into pounds and add on the remaining pounds
            double pounds = ((newWeightSt * 14) + newWeightLb);
            return BMIValue = (pounds / (newHeight * newHeight)) * 703;
        }

        public string calculateBMI()
        {
            var BMIValueInt = Convert.ToInt32(BMIValue);

            if (BMIValueInt > 18.5) {
                if (BMIValueInt > 24.9) {
                    if (BMIValueInt > 29.9) {
                        return "Obese";
                    } else {
                        return "Overweight";
                    }
                }
                else
                {
                    return "Ideal";
                }
            }
            else
            {
                return "Underweight";
            }
        }

        // Variables
        private string newName;
        private int newHeight;
        private int newWeightSt;
        private double newWeightLb;
        private double BMIValue;
    }
}
