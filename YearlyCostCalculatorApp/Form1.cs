using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YearlyCostCalculatorApp
{
    public partial class YearlyCostCalculatorUI : Form
    {
        public YearlyCostCalculatorUI()
        {
            InitializeComponent();
        }

        private double discount, discountAmount, admissionFee, monthlyFee, totalAmount, totalMonthlyFee;
        private void calculateTotalButton_Click(object sender, EventArgs e)
        {
            string className = classComboBox.Text;

            int classNumber = classComboBox.Items.IndexOf(className);

            if (discountCheckBox.Checked == true)
            {
                discount = 5;
            }
            else
            {
                discount = 0;
            }

            if (classNumber >= 0 && classNumber <= 4)
            {
                admissionFee = 10000;
                if (classNumber == 0 || classNumber == 1)
                {
                    monthlyFee = 500;
                }
                else
                {
                    monthlyFee = 1000;
                }
            }
            else
            {
                if (classNumber >= 5 && classNumber <= 7)
                {
                    admissionFee = 12000;
                    monthlyFee = 1500;
                }
                else
                {
                    admissionFee = 15000;
                    if (classNumber == 8 || classNumber == 9)
                    {
                        monthlyFee = 2000;
                    }
                    else
                    {
                        monthlyFee = 2700;
                    }
                }
            }

            totalMonthlyFee = monthlyFee*12;
            totalAmount = admissionFee + totalMonthlyFee;

            discountAmount = (totalAmount*discount)/100;

            totalAmount = totalAmount - discountAmount;

            MessageBox.Show("Total Amount of One Year : " + totalAmount.ToString());
        }

        private void YearlyCostCalculatorUI_Load(object sender, EventArgs e)
        {
            classComboBox.Items.Add("Class 1");
            classComboBox.Items.Add("Class 2");
            classComboBox.Items.Add("Class 3");
            classComboBox.Items.Add("Class 4");
            classComboBox.Items.Add("Class 5");
            classComboBox.Items.Add("Class 6");
            classComboBox.Items.Add("Class 7");
            classComboBox.Items.Add("Class 8");
            classComboBox.Items.Add("Class 9");
            classComboBox.Items.Add("Class 10");
            classComboBox.Items.Add("Class 11");
            classComboBox.Items.Add("Class 12");

            classComboBox.SelectedItem = "Class 1";
        }
    }
}
