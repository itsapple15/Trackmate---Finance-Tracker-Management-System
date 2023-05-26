namespace Trackmate___Finance_Tracker_Management_System
{
    partial class Reminders
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
            this.Lbl_Reminder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Reminder
            // 
            this.Lbl_Reminder.AutoSize = true;
            this.Lbl_Reminder.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Reminder.Location = new System.Drawing.Point(267, 21);
            this.Lbl_Reminder.Name = "Lbl_Reminder";
            this.Lbl_Reminder.Size = new System.Drawing.Size(239, 31);
            this.Lbl_Reminder.TabIndex = 7;
            this.Lbl_Reminder.Text = "Reminders";
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Reminder);
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Reminder;
    }
}