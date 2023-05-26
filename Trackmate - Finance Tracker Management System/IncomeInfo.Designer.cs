namespace Trackmate___Finance_Tracker_Management_System
{
    partial class IncomeInfo
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
            this.Lbl_IncInfo = new System.Windows.Forms.Label();
            this.Lbl_SourceInc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_Categor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_IncInfo
            // 
            this.Lbl_IncInfo.AutoSize = true;
            this.Lbl_IncInfo.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IncInfo.Location = new System.Drawing.Point(179, 9);
            this.Lbl_IncInfo.Name = "Lbl_IncInfo";
            this.Lbl_IncInfo.Size = new System.Drawing.Size(441, 31);
            this.Lbl_IncInfo.TabIndex = 6;
            this.Lbl_IncInfo.Text = "INCOME INFORMATION";
            // 
            // Lbl_SourceInc
            // 
            this.Lbl_SourceInc.AutoSize = true;
            this.Lbl_SourceInc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SourceInc.Location = new System.Drawing.Point(62, 60);
            this.Lbl_SourceInc.Name = "Lbl_SourceInc";
            this.Lbl_SourceInc.Size = new System.Drawing.Size(151, 18);
            this.Lbl_SourceInc.TabIndex = 20;
            this.Lbl_SourceInc.Text = "Source Of Income";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(219, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 21;
            // 
            // Lbl_Categor
            // 
            this.Lbl_Categor.AutoSize = true;
            this.Lbl_Categor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Categor.Location = new System.Drawing.Point(445, 59);
            this.Lbl_Categor.Name = "Lbl_Categor";
            this.Lbl_Categor.Size = new System.Drawing.Size(96, 18);
            this.Lbl_Categor.TabIndex = 22;
            this.Lbl_Categor.Text = "Categories";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(561, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 297);
            this.dataGridView1.TabIndex = 24;
            // 
            // IncomeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Lbl_Categor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Lbl_SourceInc);
            this.Controls.Add(this.Lbl_IncInfo);
            this.Name = "IncomeInfo";
            this.Text = "IncomeInfo";
            this.Load += new System.EventHandler(this.IncomeInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_IncInfo;
        private System.Windows.Forms.Label Lbl_SourceInc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_Categor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}