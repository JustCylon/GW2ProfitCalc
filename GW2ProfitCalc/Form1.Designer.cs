namespace GW2ProfitCalc
{
    partial class GWProfitCalc
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.buyCopper = new System.Windows.Forms.NumericUpDown();
            this.buySilver = new System.Windows.Forms.NumericUpDown();
            this.buyGold = new System.Windows.Forms.NumericUpDown();
            this.sellCopper = new System.Windows.Forms.NumericUpDown();
            this.sellSilver = new System.Windows.Forms.NumericUpDown();
            this.sellGold = new System.Windows.Forms.NumericUpDown();
            this.quantity = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goldLabel = new System.Windows.Forms.Label();
            this.resultsBox = new System.Windows.Forms.GroupBox();
            this.totalSell = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.totalBuy = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.TextBox();
            this.exchangeFee = new System.Windows.Forms.TextBox();
            this.listingFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyCopper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCopper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).BeginInit();
            this.resultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inputGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultsBox);
            this.splitContainer1.Size = new System.Drawing.Size(382, 274);
            this.splitContainer1.SplitterDistance = 196;
            this.splitContainer1.TabIndex = 0;
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.buyCopper);
            this.inputGroup.Controls.Add(this.buySilver);
            this.inputGroup.Controls.Add(this.buyGold);
            this.inputGroup.Controls.Add(this.sellCopper);
            this.inputGroup.Controls.Add(this.sellSilver);
            this.inputGroup.Controls.Add(this.sellGold);
            this.inputGroup.Controls.Add(this.quantity);
            this.inputGroup.Controls.Add(this.button1);
            this.inputGroup.Controls.Add(this.label8);
            this.inputGroup.Controls.Add(this.label7);
            this.inputGroup.Controls.Add(this.label4);
            this.inputGroup.Controls.Add(this.label5);
            this.inputGroup.Controls.Add(this.label6);
            this.inputGroup.Controls.Add(this.label3);
            this.inputGroup.Controls.Add(this.label2);
            this.inputGroup.Controls.Add(this.label1);
            this.inputGroup.Controls.Add(this.goldLabel);
            this.inputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputGroup.Location = new System.Drawing.Point(0, 0);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(196, 274);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Input";
            // 
            // buyCopper
            // 
            this.buyCopper.Location = new System.Drawing.Point(134, 32);
            this.buyCopper.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.buyCopper.Name = "buyCopper";
            this.buyCopper.Size = new System.Drawing.Size(37, 20);
            this.buyCopper.TabIndex = 40;
            // 
            // buySilver
            // 
            this.buySilver.Location = new System.Drawing.Point(91, 32);
            this.buySilver.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.buySilver.Name = "buySilver";
            this.buySilver.Size = new System.Drawing.Size(37, 20);
            this.buySilver.TabIndex = 39;
            // 
            // buyGold
            // 
            this.buyGold.Location = new System.Drawing.Point(21, 32);
            this.buyGold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.buyGold.Name = "buyGold";
            this.buyGold.Size = new System.Drawing.Size(63, 20);
            this.buyGold.TabIndex = 38;
            // 
            // sellCopper
            // 
            this.sellCopper.Location = new System.Drawing.Point(133, 97);
            this.sellCopper.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.sellCopper.Name = "sellCopper";
            this.sellCopper.Size = new System.Drawing.Size(37, 20);
            this.sellCopper.TabIndex = 37;
            // 
            // sellSilver
            // 
            this.sellSilver.Location = new System.Drawing.Point(90, 97);
            this.sellSilver.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.sellSilver.Name = "sellSilver";
            this.sellSilver.Size = new System.Drawing.Size(37, 20);
            this.sellSilver.TabIndex = 36;
            // 
            // sellGold
            // 
            this.sellGold.Location = new System.Drawing.Point(20, 97);
            this.sellGold.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sellGold.Name = "sellGold";
            this.sellGold.Size = new System.Drawing.Size(63, 20);
            this.sellGold.TabIndex = 35;
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(21, 167);
            this.quantity.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(63, 20);
            this.quantity.TabIndex = 34;
            this.quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 33;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Sell Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Copper";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Silver";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Gold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Copper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Silver";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Buy Price:";
            // 
            // goldLabel
            // 
            this.goldLabel.AutoSize = true;
            this.goldLabel.Location = new System.Drawing.Point(36, 55);
            this.goldLabel.Name = "goldLabel";
            this.goldLabel.Size = new System.Drawing.Size(29, 13);
            this.goldLabel.TabIndex = 18;
            this.goldLabel.Text = "Gold";
            // 
            // resultsBox
            // 
            this.resultsBox.Controls.Add(this.totalSell);
            this.resultsBox.Controls.Add(this.label13);
            this.resultsBox.Controls.Add(this.totalBuy);
            this.resultsBox.Controls.Add(this.label12);
            this.resultsBox.Controls.Add(this.profit);
            this.resultsBox.Controls.Add(this.exchangeFee);
            this.resultsBox.Controls.Add(this.listingFee);
            this.resultsBox.Controls.Add(this.label11);
            this.resultsBox.Controls.Add(this.label10);
            this.resultsBox.Controls.Add(this.label9);
            this.resultsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsBox.Location = new System.Drawing.Point(0, 0);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(182, 274);
            this.resultsBox.TabIndex = 0;
            this.resultsBox.TabStop = false;
            this.resultsBox.Text = "Results";
            // 
            // totalSell
            // 
            this.totalSell.Location = new System.Drawing.Point(30, 81);
            this.totalSell.Name = "totalSell";
            this.totalSell.ReadOnly = true;
            this.totalSell.Size = new System.Drawing.Size(132, 20);
            this.totalSell.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Sell Price:";
            // 
            // totalBuy
            // 
            this.totalBuy.Location = new System.Drawing.Point(30, 32);
            this.totalBuy.Name = "totalBuy";
            this.totalBuy.ReadOnly = true;
            this.totalBuy.Size = new System.Drawing.Size(132, 20);
            this.totalBuy.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Total Buy Price:";
            // 
            // profit
            // 
            this.profit.Location = new System.Drawing.Point(30, 239);
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            this.profit.Size = new System.Drawing.Size(133, 20);
            this.profit.TabIndex = 5;
            // 
            // exchangeFee
            // 
            this.exchangeFee.Location = new System.Drawing.Point(31, 189);
            this.exchangeFee.Name = "exchangeFee";
            this.exchangeFee.ReadOnly = true;
            this.exchangeFee.Size = new System.Drawing.Size(133, 20);
            this.exchangeFee.TabIndex = 4;
            // 
            // listingFee
            // 
            this.listingFee.Location = new System.Drawing.Point(30, 134);
            this.listingFee.Name = "listingFee";
            this.listingFee.ReadOnly = true;
            this.listingFee.Size = new System.Drawing.Size(133, 20);
            this.listingFee.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Profit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Exchange Fee:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Listing Fee: ";
            // 
            // GWProfitCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 274);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GWProfitCalc";
            this.Text = "GW2ProfitCalc";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyCopper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buySilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellCopper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantity)).EndInit();
            this.resultsBox.ResumeLayout(false);
            this.resultsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.NumericUpDown buyCopper;
        private System.Windows.Forms.NumericUpDown buySilver;
        private System.Windows.Forms.NumericUpDown buyGold;
        private System.Windows.Forms.NumericUpDown sellCopper;
        private System.Windows.Forms.NumericUpDown sellSilver;
        private System.Windows.Forms.NumericUpDown sellGold;
        private System.Windows.Forms.NumericUpDown quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label goldLabel;
        private System.Windows.Forms.GroupBox resultsBox;
        private System.Windows.Forms.TextBox profit;
        private System.Windows.Forms.TextBox exchangeFee;
        private System.Windows.Forms.TextBox listingFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox totalSell;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox totalBuy;
    }
}

