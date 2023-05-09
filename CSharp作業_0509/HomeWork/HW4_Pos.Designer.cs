namespace HomeWork
{
    public partial class HW4_Pos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HW4_Pos));
            this.btn_Cash = new System.Windows.Forms.Button();
            this.btn_CreditCard = new System.Windows.Forms.Button();
            this.Box_TotalPrice = new System.Windows.Forms.Label();
            this.lable_Disscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_ListBox = new System.Windows.Forms.Label();
            this.btn_Erase = new System.Windows.Forms.Button();
            this.label_List = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labe_Menu = new System.Windows.Forms.Label();
            this.btn_HambReduce = new System.Windows.Forms.Button();
            this.btn_HambAdd = new System.Windows.Forms.Button();
            this.btn_ColaReduce = new System.Windows.Forms.Button();
            this.btn_ColaAdd = new System.Windows.Forms.Button();
            this.btn_IceReduce = new System.Windows.Forms.Button();
            this.btn_IceAdd = new System.Windows.Forms.Button();
            this.btn_PieReduce = new System.Windows.Forms.Button();
            this.btn_PieAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Pie = new System.Windows.Forms.Label();
            this.label_IceCream = new System.Windows.Forms.Label();
            this.label_Cola = new System.Windows.Forms.Label();
            this.labelBurger = new System.Windows.Forms.Label();
            this.label_Bur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cash
            // 
            this.btn_Cash.Location = new System.Drawing.Point(26, 108);
            this.btn_Cash.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Cash.Name = "btn_Cash";
            this.btn_Cash.Size = new System.Drawing.Size(167, 80);
            this.btn_Cash.TabIndex = 6;
            this.btn_Cash.Text = "現金";
            this.btn_Cash.UseVisualStyleBackColor = true;
            this.btn_Cash.Click += new System.EventHandler(this.btn_Cash_Click);
            // 
            // btn_CreditCard
            // 
            this.btn_CreditCard.Location = new System.Drawing.Point(251, 108);
            this.btn_CreditCard.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CreditCard.Name = "btn_CreditCard";
            this.btn_CreditCard.Size = new System.Drawing.Size(167, 80);
            this.btn_CreditCard.TabIndex = 7;
            this.btn_CreditCard.Text = "信用卡";
            this.btn_CreditCard.UseVisualStyleBackColor = true;
            this.btn_CreditCard.Click += new System.EventHandler(this.btn_CreditCard_Click);
            // 
            // Box_TotalPrice
            // 
            this.Box_TotalPrice.BackColor = System.Drawing.Color.Black;
            this.Box_TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Box_TotalPrice.ForeColor = System.Drawing.Color.White;
            this.Box_TotalPrice.Location = new System.Drawing.Point(30, 118);
            this.Box_TotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Box_TotalPrice.Name = "Box_TotalPrice";
            this.Box_TotalPrice.Size = new System.Drawing.Size(518, 96);
            this.Box_TotalPrice.TabIndex = 9;
            this.Box_TotalPrice.Text = "NT$ 0";
            this.Box_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lable_Disscount
            // 
            this.lable_Disscount.AutoSize = true;
            this.lable_Disscount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lable_Disscount.Location = new System.Drawing.Point(180, 204);
            this.lable_Disscount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lable_Disscount.Name = "lable_Disscount";
            this.lable_Disscount.Size = new System.Drawing.Size(260, 48);
            this.lable_Disscount.TabIndex = 5;
            this.lable_Disscount.Text = "信用卡享九折!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 48);
            this.label4.TabIndex = 11;
            this.label4.Text = "總金額 Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 48);
            this.label2.TabIndex = 12;
            this.label2.Text = "付款方式";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lable_Disscount);
            this.panel2.Controls.Add(this.btn_CreditCard);
            this.panel2.Controls.Add(this.btn_Cash);
            this.panel2.Location = new System.Drawing.Point(828, 558);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 276);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Box_TotalPrice);
            this.panel3.Location = new System.Drawing.Point(1321, 558);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 276);
            this.panel3.TabIndex = 14;
            // 
            // label_ListBox
            // 
            this.label_ListBox.BackColor = System.Drawing.Color.MintCream;
            this.label_ListBox.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_ListBox.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_ListBox.Location = new System.Drawing.Point(9, 94);
            this.label_ListBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_ListBox.Name = "label_ListBox";
            this.label_ListBox.Size = new System.Drawing.Size(1045, 409);
            this.label_ListBox.TabIndex = 8;
            this.label_ListBox.Text = "尚未點餐";
            this.label_ListBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_Erase
            // 
            this.btn_Erase.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Erase.Location = new System.Drawing.Point(891, 696);
            this.btn_Erase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Erase.Name = "btn_Erase";
            this.btn_Erase.Size = new System.Drawing.Size(186, 80);
            this.btn_Erase.TabIndex = 10;
            this.btn_Erase.Text = "清除清單";
            this.btn_Erase.UseVisualStyleBackColor = true;
            this.btn_Erase.Click += new System.EventHandler(this.btn_Erase_Click);
            // 
            // label_List
            // 
            this.label_List.AutoSize = true;
            this.label_List.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_List.Location = new System.Drawing.Point(6, 22);
            this.label_List.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_List.Name = "label_List";
            this.label_List.Size = new System.Drawing.Size(242, 48);
            this.label_List.TabIndex = 15;
            this.label_List.Text = "購物清單 List";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label_List);
            this.panel4.Controls.Add(this.btn_Erase);
            this.panel4.Controls.Add(this.label_ListBox);
            this.panel4.Location = new System.Drawing.Point(828, 24);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 522);
            this.panel4.TabIndex = 16;
            // 
            // labe_Menu
            // 
            this.labe_Menu.AutoSize = true;
            this.labe_Menu.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labe_Menu.Location = new System.Drawing.Point(20, 0);
            this.labe_Menu.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labe_Menu.Name = "labe_Menu";
            this.labe_Menu.Size = new System.Drawing.Size(210, 48);
            this.labe_Menu.TabIndex = 4;
            this.labe_Menu.Text = "菜單 Menu";
            // 
            // btn_HambReduce
            // 
            this.btn_HambReduce.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HambReduce.Location = new System.Drawing.Point(234, 282);
            this.btn_HambReduce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_HambReduce.Name = "btn_HambReduce";
            this.btn_HambReduce.Size = new System.Drawing.Size(80, 70);
            this.btn_HambReduce.TabIndex = 5;
            this.btn_HambReduce.Text = "-";
            this.btn_HambReduce.UseVisualStyleBackColor = true;
            this.btn_HambReduce.Click += new System.EventHandler(this.btn_HambReduce_Click);
            // 
            // btn_HambAdd
            // 
            this.btn_HambAdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_HambAdd.Location = new System.Drawing.Point(74, 282);
            this.btn_HambAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_HambAdd.Name = "btn_HambAdd";
            this.btn_HambAdd.Size = new System.Drawing.Size(80, 70);
            this.btn_HambAdd.TabIndex = 6;
            this.btn_HambAdd.Text = "+";
            this.btn_HambAdd.UseVisualStyleBackColor = true;
            this.btn_HambAdd.Click += new System.EventHandler(this.btn_HambAdd_Click);
            // 
            // btn_ColaReduce
            // 
            this.btn_ColaReduce.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ColaReduce.Location = new System.Drawing.Point(637, 282);
            this.btn_ColaReduce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ColaReduce.Name = "btn_ColaReduce";
            this.btn_ColaReduce.Size = new System.Drawing.Size(80, 70);
            this.btn_ColaReduce.TabIndex = 7;
            this.btn_ColaReduce.Text = "-";
            this.btn_ColaReduce.UseVisualStyleBackColor = true;
            this.btn_ColaReduce.Click += new System.EventHandler(this.btn_ColaReduce_Click);
            // 
            // btn_ColaAdd
            // 
            this.btn_ColaAdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ColaAdd.Location = new System.Drawing.Point(485, 282);
            this.btn_ColaAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ColaAdd.Name = "btn_ColaAdd";
            this.btn_ColaAdd.Size = new System.Drawing.Size(80, 70);
            this.btn_ColaAdd.TabIndex = 8;
            this.btn_ColaAdd.Text = "+";
            this.btn_ColaAdd.UseVisualStyleBackColor = true;
            this.btn_ColaAdd.Click += new System.EventHandler(this.btn_ColaAdd_Click);
            // 
            // btn_IceReduce
            // 
            this.btn_IceReduce.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_IceReduce.Location = new System.Drawing.Point(234, 674);
            this.btn_IceReduce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_IceReduce.Name = "btn_IceReduce";
            this.btn_IceReduce.Size = new System.Drawing.Size(80, 70);
            this.btn_IceReduce.TabIndex = 9;
            this.btn_IceReduce.Text = "-";
            this.btn_IceReduce.UseVisualStyleBackColor = true;
            this.btn_IceReduce.Click += new System.EventHandler(this.btn_IceReduce_Click);
            // 
            // btn_IceAdd
            // 
            this.btn_IceAdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_IceAdd.Location = new System.Drawing.Point(74, 674);
            this.btn_IceAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_IceAdd.Name = "btn_IceAdd";
            this.btn_IceAdd.Size = new System.Drawing.Size(80, 70);
            this.btn_IceAdd.TabIndex = 10;
            this.btn_IceAdd.Text = "+";
            this.btn_IceAdd.UseVisualStyleBackColor = true;
            this.btn_IceAdd.Click += new System.EventHandler(this.btn_IceAdd_Click);
            // 
            // btn_PieReduce
            // 
            this.btn_PieReduce.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PieReduce.Location = new System.Drawing.Point(637, 674);
            this.btn_PieReduce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_PieReduce.Name = "btn_PieReduce";
            this.btn_PieReduce.Size = new System.Drawing.Size(80, 70);
            this.btn_PieReduce.TabIndex = 11;
            this.btn_PieReduce.Text = "-";
            this.btn_PieReduce.UseVisualStyleBackColor = true;
            this.btn_PieReduce.Click += new System.EventHandler(this.btn_PieReduce_Click);
            // 
            // btn_PieAdd
            // 
            this.btn_PieAdd.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PieAdd.Location = new System.Drawing.Point(485, 674);
            this.btn_PieAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_PieAdd.Name = "btn_PieAdd";
            this.btn_PieAdd.Size = new System.Drawing.Size(80, 70);
            this.btn_PieAdd.TabIndex = 12;
            this.btn_PieAdd.Text = "+";
            this.btn_PieAdd.UseVisualStyleBackColor = true;
            this.btn_PieAdd.Click += new System.EventHandler(this.btn_PieAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Bur);
            this.panel1.Controls.Add(this.btn_HambAdd);
            this.panel1.Controls.Add(this.btn_PieAdd);
            this.panel1.Controls.Add(this.btn_PieReduce);
            this.panel1.Controls.Add(this.label_Pie);
            this.panel1.Controls.Add(this.btn_IceAdd);
            this.panel1.Controls.Add(this.btn_IceReduce);
            this.panel1.Controls.Add(this.btn_ColaAdd);
            this.panel1.Controls.Add(this.btn_ColaReduce);
            this.panel1.Controls.Add(this.btn_HambReduce);
            this.panel1.Controls.Add(this.label_IceCream);
            this.panel1.Controls.Add(this.label_Cola);
            this.panel1.Controls.Add(this.labelBurger);
            this.panel1.Controls.Add(this.labe_Menu);
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 828);
            this.panel1.TabIndex = 4;
            // 
            // label_Pie
            // 
            this.label_Pie.BackColor = System.Drawing.Color.White;
            this.label_Pie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Pie.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Pie.Image = ((System.Drawing.Image)(resources.GetObject("label_Pie.Image")));
            this.label_Pie.Location = new System.Drawing.Point(416, 451);
            this.label_Pie.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Pie.Name = "label_Pie";
            this.label_Pie.Size = new System.Drawing.Size(338, 298);
            this.label_Pie.TabIndex = 16;
            
            // 
            // label_IceCream
            // 
            this.label_IceCream.BackColor = System.Drawing.Color.White;
            this.label_IceCream.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_IceCream.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_IceCream.Image = ((System.Drawing.Image)(resources.GetObject("label_IceCream.Image")));
            this.label_IceCream.Location = new System.Drawing.Point(28, 451);
            this.label_IceCream.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_IceCream.Name = "label_IceCream";
            this.label_IceCream.Size = new System.Drawing.Size(351, 298);
            this.label_IceCream.TabIndex = 15;
            // 
            // label_Cola
            // 
            this.label_Cola.BackColor = System.Drawing.Color.White;
            this.label_Cola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Cola.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Cola.Image = ((System.Drawing.Image)(resources.GetObject("label_Cola.Image")));
            this.label_Cola.Location = new System.Drawing.Point(416, 70);
            this.label_Cola.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Cola.Name = "label_Cola";
            this.label_Cola.Size = new System.Drawing.Size(338, 292);
            this.label_Cola.TabIndex = 14;
            // 
            // labelBurger
            // 
            this.labelBurger.BackColor = System.Drawing.Color.White;
            this.labelBurger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBurger.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelBurger.Image = ((System.Drawing.Image)(resources.GetObject("labelBurger.Image")));
            this.labelBurger.Location = new System.Drawing.Point(28, 72);
            this.labelBurger.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelBurger.Name = "labelBurger";
            this.labelBurger.Size = new System.Drawing.Size(351, 290);
            this.labelBurger.TabIndex = 13;
            this.labelBurger.Text = "\r\n";
            // 
            // label_Bur
            // 
            this.label_Bur.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Bur.Location = new System.Drawing.Point(68, 371);
            this.label_Bur.Name = "label_Bur";
            this.label_Bur.Size = new System.Drawing.Size(262, 68);
            this.label_Bur.TabIndex = 17;
            this.label_Bur.Text = "漢堡 Hamburger\r\nNT 70\r\n\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(455, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 68);
            this.label1.TabIndex = 18;
            this.label1.Text = "可樂 Cola\r\nNT 35\r\n\r\n";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(455, 754);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 68);
            this.label3.TabIndex = 19;
            this.label3.Text = "蘋果派 ApplePie\r\nNT 40\r\n\r\n";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(68, 754);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 68);
            this.label5.TabIndex = 20;
            this.label5.Text = "冰淇淋 Ice Cream\r\nNT 20\r\n\r\n";
            // 
            // HW4_Pos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 855);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HW4_Pos";
            this.Text = "Mac Pos";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Cash;
        private System.Windows.Forms.Button btn_CreditCard;
        private System.Windows.Forms.Label Box_TotalPrice;
        private System.Windows.Forms.Label lable_Disscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_ListBox;
        private System.Windows.Forms.Button btn_Erase;
        private System.Windows.Forms.Label label_List;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labe_Menu;
        private System.Windows.Forms.Button btn_HambReduce;
        private System.Windows.Forms.Button btn_HambAdd;
        private System.Windows.Forms.Button btn_ColaReduce;
        private System.Windows.Forms.Button btn_ColaAdd;
        private System.Windows.Forms.Button btn_IceReduce;
        private System.Windows.Forms.Button btn_IceAdd;
        private System.Windows.Forms.Button btn_PieReduce;
        private System.Windows.Forms.Button btn_PieAdd;
        private System.Windows.Forms.Label labelBurger;
        private System.Windows.Forms.Label label_Cola;
        private System.Windows.Forms.Label label_IceCream;
        private System.Windows.Forms.Label label_Pie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Bur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}