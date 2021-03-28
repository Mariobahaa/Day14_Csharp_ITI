
namespace UI
{
    partial class DV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pubDate = new System.Windows.Forms.DateTimePicker();
            this.sales = new System.Windows.Forms.NumericUpDown();
            this.royalty = new System.Windows.Forms.NumericUpDown();
            this.advance = new System.Windows.Forms.NumericUpDown();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.title_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.royalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // pubDate
            // 
            this.pubDate.Location = new System.Drawing.Point(155, 336);
            this.pubDate.Name = "pubDate";
            this.pubDate.Size = new System.Drawing.Size(302, 27);
            this.pubDate.TabIndex = 68;
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(155, 270);
            this.sales.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(302, 27);
            this.sales.TabIndex = 67;
            // 
            // royalty
            // 
            this.royalty.Location = new System.Drawing.Point(155, 237);
            this.royalty.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.royalty.Name = "royalty";
            this.royalty.Size = new System.Drawing.Size(302, 27);
            this.royalty.TabIndex = 66;
            // 
            // advance
            // 
            this.advance.Location = new System.Drawing.Point(155, 204);
            this.advance.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.advance.Name = "advance";
            this.advance.Size = new System.Drawing.Size(302, 27);
            this.advance.TabIndex = 65;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(155, 172);
            this.price.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(302, 27);
            this.price.TabIndex = 64;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(155, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(302, 44);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 138);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 28);
            this.comboBox1.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 61;
            this.label10.Text = "Pub. Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 60;
            this.label9.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 20);
            this.label8.TabIndex = 59;
            this.label8.Text = "Sales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Royalty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Advance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Title";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(44, 39);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 20);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "Title ID";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(155, 303);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(302, 27);
            this.notes.TabIndex = 51;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(155, 72);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(302, 27);
            this.title.TabIndex = 50;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(155, 105);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(302, 27);
            this.type.TabIndex = 49;
            // 
            // title_id
            // 
            this.title_id.Location = new System.Drawing.Point(155, 39);
            this.title_id.Name = "title_id";
            this.title_id.Size = new System.Drawing.Size(302, 27);
            this.title_id.TabIndex = 48;
            // 
            // DV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 468);
            this.Controls.Add(this.pubDate);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.royalty);
            this.Controls.Add(this.advance);
            this.Controls.Add(this.price);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.title);
            this.Controls.Add(this.type);
            this.Controls.Add(this.title_id);
            this.Name = "DV";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.royalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pubDate;
        private System.Windows.Forms.NumericUpDown sales;
        private System.Windows.Forms.NumericUpDown royalty;
        private System.Windows.Forms.NumericUpDown advance;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox title_id;
    }
}

