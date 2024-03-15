using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Lab5Var11
{
    public partial class Form1 : Form
    {
        Dictionary<string, Image> pizzaImages = new Dictionary<string, Image>()
        {
            { "Paperoni 115 uah", Properties.Resources.paperoni },
            { "Margarita 130 uah", Properties.Resources.margarita },
            { "Gavay 110 uah", Properties.Resources.gavayjpg },
            { "Diablo 125 uah", Properties.Resources.diablo },
        };

        public Form1()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += radioButton_CheckedChanged;
            radioButton2.CheckedChanged += radioButton_CheckedChanged;
            radioButton3.CheckedChanged += radioButton_CheckedChanged;
            radioButton4.CheckedChanged += radioButton_CheckedChanged;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                string pizzaType = radioButton.Text;

                if (pizzaImages.ContainsKey(pizzaType))
                {
                    pictureBox1.Image = pizzaImages[pizzaType];
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = (int)Quantity.Value;
            string type = radioButton1.Checked ? radioButton1.Text :
                          radioButton2.Checked ? radioButton2.Text :
                          radioButton3.Checked ? radioButton3.Text :
                          radioButton4.Checked ? radioButton4.Text : "¬ибер≥ть тип п≥ци";
            int? price = ExtractNumberFromString(type);

            if (price != null)
            {
                MessageBox.Show("¬и маЇте заплатити: " + (price * quantity) + " uah");
            }
            else
            {
                MessageBox.Show("¬ибер≥ть тип п≥ци");
            }
        }

        static int? ExtractNumberFromString(string input)
        {
            string numberString = new string(input.Where(char.IsDigit).ToArray());

            if (!string.IsNullOrEmpty(numberString))
            {
                if (int.TryParse(numberString, out int number))
                {
                    return number;
                }
            }

            return null;
        }
    }
}
