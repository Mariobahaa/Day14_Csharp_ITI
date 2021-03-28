
namespace UI
{
    partial class GV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDGVSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(727, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDGVSave
            // 
            this.btnDGVSave.BackColor = System.Drawing.Color.Lime;
            this.btnDGVSave.ForeColor = System.Drawing.Color.White;
            this.btnDGVSave.Location = new System.Drawing.Point(227, 425);
            this.btnDGVSave.Name = "btnDGVSave";
            this.btnDGVSave.Size = new System.Drawing.Size(267, 55);
            this.btnDGVSave.TabIndex = 1;
            this.btnDGVSave.Text = "Save Changes";
            this.btnDGVSave.UseVisualStyleBackColor = false;
            this.btnDGVSave.Click += new System.EventHandler(this.btnDGVSave_Click);
            // 
            // GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 492);
            this.Controls.Add(this.btnDGVSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GV";
            this.Text = "GV";
            this.Load += new System.EventHandler(this.GV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDGVSave;
    }
}