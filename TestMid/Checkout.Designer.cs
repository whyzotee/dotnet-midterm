namespace TestMid
{
    partial class Checkout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.item_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.item_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totol = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.money = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kanit", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Checkout";
            // 
            // item_name
            // 
            this.item_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_name.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_name.ForeColor = System.Drawing.Color.White;
            this.item_name.Location = new System.Drawing.Point(63, 186);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(583, 293);
            this.item_name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 54);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // item_price
            // 
            this.item_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.item_price.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.item_price.ForeColor = System.Drawing.Color.White;
            this.item_price.Location = new System.Drawing.Point(703, 186);
            this.item_price.Name = "item_price";
            this.item_price.Size = new System.Drawing.Size(118, 293);
            this.item_price.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(703, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 54);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // totol
            // 
            this.totol.AutoSize = true;
            this.totol.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totol.ForeColor = System.Drawing.Color.White;
            this.totol.Location = new System.Drawing.Point(540, 517);
            this.totol.Name = "totol";
            this.totol.Size = new System.Drawing.Size(184, 54);
            this.totol.TabIndex = 12;
            this.totol.Text = "Total Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kanit", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 54);
            this.label3.TabIndex = 13;
            this.label3.Text = "จำนวนเงิน";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Kanit", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(942, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "คำนวน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // money
            // 
            this.money.Font = new System.Drawing.Font("Kanit", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money.Location = new System.Drawing.Point(733, 594);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(189, 45);
            this.money.TabIndex = 15;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1064, 657);
            this.Controls.Add(this.money);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.item_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.label1);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label item_name;
        private Label label2;
        private Label item_price;
        private Label label6;
        private Label totol;
        private Label label3;
        private Button button1;
        private TextBox money;
    }
}