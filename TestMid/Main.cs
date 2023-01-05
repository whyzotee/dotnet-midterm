using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TestMid
{
    public partial class Main : Form
    {
        Checkout checkoutpage = new Checkout();

        public static string[,] data = new string[6,2];
        
        string[,] micro = new string[6,2] { 
            { "Arduino UNO R3", "1085" }, { "Arduino Mega", "750" },
            { "Arduino Nano", "190"}, { "Arduino Micro","395"}, 
            { "NodeMCU ESP-8266","120"},{ "NodeMCU ESP-32","215"} 
        };
        string[] inputD = { "Switch", "Button", "Joystick", "VR" };
        string[] outputD = { "LED (Red)", "LED (Green)", "LED (Yellow)", "LED (RGB)", "LCD Display" };
        string[] other = { "Wheel (x2)", "Wheel (x4)", "Acrylic", "Jumper Wire", "USB Wire", "Type C Wire" };

        int inCart;

        public Main()
        {
            InitializeComponent();
            System.Console.WriteLine(micro[0,0]);
        }

        private void radioButton_Select(object sender, EventArgs e)
        {
            RadioButton menu = (RadioButton)sender;

            switch (menu.Name)
            {
                case "radioButton1":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < 6; i++)
                        item_listBox.Items.Add(micro[i, 0]);
                    break;
                case "radioButton2":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < inputD.Length; i++)
                        item_listBox.Items.Add(inputD[i]);
                    break;
                case "radioButton3":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < outputD.Length; i++)
                        item_listBox.Items.Add(outputD[i]);
                    break;
                case "radioButton4":
                    item_listBox.Items.Clear();
                    for (int i = 0; i < other.Length; i++)
                        item_listBox.Items.Add(other[i]);
                    break;
            }
        }

        private void Item_Select(object sender, EventArgs e)
        {
            RadioButton[] menu = { radioButton1, radioButton2, radioButton3, radioButton4 };
            Array[] group = {micro, inputD, outputD, other};
            
            string item_select = item_listBox.SelectedItem.ToString();

            string[] micro_img = { @"..\..\..\Resources\mirco\micro_1.jpg", @"..\..\..\Resources\mirco\micro_2.jpg" ,
            @"..\..\..\Resources\mirco\micro_3.jpg", @"..\..\..\Resources\mirco\micro_4.png", @"..\..\..\Resources\mirco\micro_5.png"
            , @"..\..\..\Resources\mirco\micro_6.png"};

        
            for (int i = 0; i < menu.Length; i++) 
            {
                if (menu[i].Checked)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (item_select == micro[j, 0])
                        {
                            item_img.Image = Image.FromFile(micro_img[j]);
                            item_name.Text = $"Name : {item_select}";
                            item_price.Text = $"Price : {micro[j, 1]} ฿";
                            item_info.Text = $"This is {item_select}";
                        }
                    }

                    for (int j = 0; j < inputD.Length; j++)
                    {
                        if (item_select == inputD[j])
                        {
                            item_img.Image = Image.FromFile(micro_img[j]);
                            item_name.Text = $"Name : {item_select}";
                            item_price.Text = $"Price : {micro[j,1]} ฿";
                            item_info.Text = $"This is {item_select}";
                        }
                    }
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
