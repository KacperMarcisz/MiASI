namespace Decisions
{
    partial class Main
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
            this.label2 = new System.Windows.Forms.Label();
            this.realizationSize = new System.Windows.Forms.TextBox();
            this.demand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.price1 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.price3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.discountPrice = new System.Windows.Forms.TextBox();
            this.regularPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CostValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.IncomeValue = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.IncomeValue2 = new System.Windows.Forms.Label();
            this.ProfitValue = new System.Windows.Forms.Label();
            this.readDataButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CalculateValuesButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wielkosc zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Popyt na koszulki";
            // 
            // realizationSize
            // 
            this.realizationSize.Location = new System.Drawing.Point(121, 37);
            this.realizationSize.Name = "realizationSize";
            this.realizationSize.Size = new System.Drawing.Size(100, 20);
            this.realizationSize.TabIndex = 2;
            // 
            // demand
            // 
            this.demand.Location = new System.Drawing.Point(121, 73);
            this.demand.Name = "demand";
            this.demand.Size = new System.Drawing.Size(100, 20);
            this.demand.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oblicz koszt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // price1
            // 
            this.price1.Location = new System.Drawing.Point(365, 37);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(100, 20);
            this.price1.TabIndex = 5;
            this.price1.Text = "10";
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(365, 73);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(100, 20);
            this.price2.TabIndex = 6;
            this.price2.Text = "9";
            // 
            // price3
            // 
            this.price3.Location = new System.Drawing.Point(365, 113);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(100, 20);
            this.price3.TabIndex = 7;
            this.price3.Text = "8,50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cena 1 partii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cena 2 partii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cena 3 partii";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.discountPrice);
            this.groupBox1.Controls.Add(this.regularPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.price3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.price2);
            this.groupBox1.Controls.Add(this.realizationSize);
            this.groupBox1.Controls.Add(this.price1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.demand);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 214);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane wejsciowe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "1 = 200 szt";
            // 
            // discountPrice
            // 
            this.discountPrice.Location = new System.Drawing.Point(121, 151);
            this.discountPrice.Name = "discountPrice";
            this.discountPrice.Size = new System.Drawing.Size(100, 20);
            this.discountPrice.TabIndex = 14;
            this.discountPrice.Text = "6";
            // 
            // regularPrice
            // 
            this.regularPrice.Location = new System.Drawing.Point(121, 120);
            this.regularPrice.Name = "regularPrice";
            this.regularPrice.Size = new System.Drawing.Size(100, 20);
            this.regularPrice.TabIndex = 13;
            this.regularPrice.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cena ze znizka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Regularna cena";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(521, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // CostValue
            // 
            this.CostValue.AutoSize = true;
            this.CostValue.Location = new System.Drawing.Point(106, 283);
            this.CostValue.Name = "CostValue";
            this.CostValue.Size = new System.Drawing.Size(33, 13);
            this.CostValue.TabIndex = 14;
            this.CostValue.Text = "Koszt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Koszt";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 310);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Przychód";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Dochód";
            // 
            // IncomeValue
            // 
            this.IncomeValue.AutoSize = true;
            this.IncomeValue.Location = new System.Drawing.Point(106, 310);
            this.IncomeValue.Name = "IncomeValue";
            this.IncomeValue.Size = new System.Drawing.Size(51, 13);
            this.IncomeValue.TabIndex = 18;
            this.IncomeValue.Text = "Przychód";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 340);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Przychód2";
            // 
            // IncomeValue2
            // 
            this.IncomeValue2.AutoSize = true;
            this.IncomeValue2.Location = new System.Drawing.Point(106, 340);
            this.IncomeValue2.Name = "IncomeValue2";
            this.IncomeValue2.Size = new System.Drawing.Size(57, 13);
            this.IncomeValue2.TabIndex = 21;
            this.IncomeValue2.Text = "Przychod2";
            // 
            // ProfitValue
            // 
            this.ProfitValue.AutoSize = true;
            this.ProfitValue.Location = new System.Drawing.Point(106, 367);
            this.ProfitValue.Name = "ProfitValue";
            this.ProfitValue.Size = new System.Drawing.Size(45, 13);
            this.ProfitValue.TabIndex = 22;
            this.ProfitValue.Text = "Dochod";
            // 
            // readDataButton
            // 
            this.readDataButton.Location = new System.Drawing.Point(540, 32);
            this.readDataButton.Name = "readDataButton";
            this.readDataButton.Size = new System.Drawing.Size(133, 37);
            this.readDataButton.TabIndex = 23;
            this.readDataButton.Text = "Wczytaj dane z pliku";
            this.readDataButton.UseVisualStyleBackColor = true;
            this.readDataButton.Click += new System.EventHandler(this.readDataButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CalculateValuesButton
            // 
            this.CalculateValuesButton.Location = new System.Drawing.Point(540, 85);
            this.CalculateValuesButton.Name = "CalculateValuesButton";
            this.CalculateValuesButton.Size = new System.Drawing.Size(133, 23);
            this.CalculateValuesButton.TabIndex = 24;
            this.CalculateValuesButton.Text = "Oblicz Wartosci";
            this.CalculateValuesButton.UseVisualStyleBackColor = true;
            this.CalculateValuesButton.Click += new System.EventHandler(this.CalculateValuesButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(211, 449);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(521, 150);
            this.dataGridView2.TabIndex = 25;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 626);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.CalculateValuesButton);
            this.Controls.Add(this.readDataButton);
            this.Controls.Add(this.ProfitValue);
            this.Controls.Add(this.IncomeValue2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.IncomeValue);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CostValue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Kacper Marcisz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox realizationSize;
        private System.Windows.Forms.TextBox demand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox price3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox discountPrice;
        private System.Windows.Forms.TextBox regularPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label CostValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label IncomeValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label IncomeValue2;
        private System.Windows.Forms.Label ProfitValue;
        private System.Windows.Forms.Button readDataButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button CalculateValuesButton;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

