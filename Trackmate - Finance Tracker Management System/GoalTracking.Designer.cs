namespace Trackmate___Finance_Tracker_Management_System
{
    partial class GoalTracking
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Categor_Lbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GoalName_Lbl = new System.Windows.Forms.Label();
            this.Lbl_GoalTrack = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 28;
            // 
            // Categor_Lbl
            // 
            this.Categor_Lbl.AutoSize = true;
            this.Categor_Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categor_Lbl.Location = new System.Drawing.Point(439, 59);
            this.Categor_Lbl.Name = "Categor_Lbl";
            this.Categor_Lbl.Size = new System.Drawing.Size(96, 18);
            this.Categor_Lbl.TabIndex = 27;
            this.Categor_Lbl.Text = "Categories";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 26;
            // 
            // GoalName_Lbl
            // 
            this.GoalName_Lbl.AutoSize = true;
            this.GoalName_Lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoalName_Lbl.Location = new System.Drawing.Point(77, 63);
            this.GoalName_Lbl.Name = "GoalName_Lbl";
            this.GoalName_Lbl.Size = new System.Drawing.Size(95, 18);
            this.GoalName_Lbl.TabIndex = 25;
            this.GoalName_Lbl.Text = "Goal Name";
            // 
            // Lbl_GoalTrack
            // 
            this.Lbl_GoalTrack.AutoSize = true;
            this.Lbl_GoalTrack.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GoalTrack.Location = new System.Drawing.Point(235, 9);
            this.Lbl_GoalTrack.Name = "Lbl_GoalTrack";
            this.Lbl_GoalTrack.Size = new System.Drawing.Size(327, 31);
            this.Lbl_GoalTrack.TabIndex = 24;
            this.Lbl_GoalTrack.Text = "GOAL TRACKING";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 297);
            this.dataGridView1.TabIndex = 29;
            // 
            // GoalTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Categor_Lbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GoalName_Lbl);
            this.Controls.Add(this.Lbl_GoalTrack);
            this.Name = "GoalTracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoalTracking";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Categor_Lbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label GoalName_Lbl;
        private System.Windows.Forms.Label Lbl_GoalTrack;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}