using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestMid.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TestMid
{
    public partial class Main : Form
    {
        Checkout checkoutpage = new Checkout();

        public static string[,] data = new string[6,2];
 
        string[,] micro = { 
            { "Arduino UNO R3", "1085", "1" }, { "Arduino Mega", "750" , "1"},
            { "Arduino Nano", "190", "1"}, { "Arduino Micro","395", "1"}, 
            { "NodeMCU ESP-8266","120", "1"},{ "NodeMCU ESP-32","215", "1"} 
        };
    
        string[,] inputD = { 
            { "Switch [10 PCS]", "54", "1" }, { "Button" , "19", "1"}, 
            { "Joystick" , "30", "1"}, { "VR" , "15", "1"} 
        };

        string[,] outputD = { 
            { "LED (Red) [10 PCS]", "10", "1" }, { "LED (Green) [10 PCS]", "10", "1" }, 
            { "LED (Yellow) [10 PCS]", "10", "1" }, { "LED (RGB)", "28", "1" }, 
            { "LCD Display", "60", "1" } 
        };

        string[,] other = { 
            { "Wheel [2 PCS]" , "40", "1"}, { "Wheel [4 PCS]", "40", "1" }, { "Acrylic (10cm x 10cm)", "60", "1" },
            { "Jumper Wire [10 PCS]", "100", "1" }, { "USB Wire (100m)", "200", "1" }, { "Type C Wire", "150", "1" } 
        };

        int inCart;

        public Main()
        {
            InitializeComponent();
        }

        private void radioButton_Select(object sender, EventArgs e)
        {
            RadioButton menu = (RadioButton)sender;

            switch (menu.Name)
            {
                case "radioButton1":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < micro.GetLength(0); i++)
                        item_listBox.Items.Add(micro[i, 0]);
                    break;
                case "radioButton2":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < inputD.GetLength(0); i++)
                        item_listBox.Items.Add(inputD[i, 0]);
                    break;
                case "radioButton3":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < outputD.GetLength(0); i++)
                        item_listBox.Items.Add(outputD[i, 0]);
                    break;
                case "radioButton4":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < other.GetLength(0); i++)
                        item_listBox.Items.Add(other[i, 0]);
                    break;
            }
        }

        private void Item_Select(object sender, EventArgs e)
        {
            Array[] group = { micro, inputD, outputD, other };
            RadioButton[] menu = { radioButton1, radioButton2, radioButton3, radioButton4 };
            
            string[] name_group = { "micro", "inputD", "outputD", "other" };
            int item_select = item_listBox.SelectedIndex;
            for (int i = 0; i < menu.Length; i++) 
            {
                if (menu[i].Checked)
                {
                    
                    //item_img.Image = Image.FromFile($@"..\..\..\Resources\{nameof((string[,])group[i])}\{nameof((string[,])group[i])}_{i + 1}.png");
                    item_name.Text = $"Name : { ((string[,])group[i])[item_select, 0] }";
                    item_price.Text = $"Price : { ((string[,])group[i])[item_select, 1] } ฿";
                    item_info.Text = $"This is { ((string[,])group[i])[item_select, 0] }";
                }
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item_select = item_listBox.SelectedItem.ToString();

            for (int i = 0; i < micro.GetLength(0); i++) 
            {
                if (item_select == micro[i, 0]) 
                {
                    data[i, 0] = micro[i, 0];
                    data[i, 1] = micro[i, 1];
                    data[i, 2] = micro[i, 2];
                    MessageBox.Show($"{data[i, 0]} is added to cart!");
                }
            }
            
            inCart += 1;
            button2.Text = $"Cart ({inCart})";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            checkoutpage.ShowDialog();
            this.Close();
        }
    }
}
