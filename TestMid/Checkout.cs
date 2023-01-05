using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestMid
{
    public partial class Checkout : Form
    {
        int total;
        public Checkout()
        {
            InitializeComponent();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Main.data.GetLength(0); i++) 
            {   
                if (String.IsNullOrEmpty(Main.data[i, 0])) 
                    continue;
                
                item_name.Text += Main.data[i, 0] + "\n";
                item_price.Text += Main.data[i, 1] + "\n";
                total += int.Parse(Main.data[i, 1]);
            }
            totol.Text = $"Total Price : {total} ฿";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"เงินทอนทั้งหมด {int.Parse(money.Text) -total}");
        }
    }
}
