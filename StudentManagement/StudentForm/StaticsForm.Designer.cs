
namespace StudentManagement.StudentForm
{
    partial class StaticsForm
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
            this.totalPanel = new System.Windows.Forms.Panel();
            this.malePanel = new System.Windows.Forms.Panel();
            this.femalePanel = new System.Windows.Forms.Panel();
            this.totalLabel = new System.Windows.Forms.Label();
            this.maleLabel = new System.Windows.Forms.Label();
            this.femaleLabel = new System.Windows.Forms.Label();
            this.totalPanel.SuspendLayout();
            this.malePanel.SuspendLayout();
            this.femalePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalPanel
            // 
            this.totalPanel.BackColor = System.Drawing.Color.DarkOrchid;
            this.totalPanel.Controls.Add(this.totalLabel);
            this.totalPanel.Location = new System.Drawing.Point(12, 12);
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new System.Drawing.Size(757, 187);
            this.totalPanel.TabIndex = 0;
            // 
            // malePanel
            // 
            this.malePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.malePanel.Controls.Add(this.maleLabel);
            this.malePanel.Location = new System.Drawing.Point(12, 218);
            this.malePanel.Name = "malePanel";
            this.malePanel.Size = new System.Drawing.Size(382, 152);
            this.malePanel.TabIndex = 1;
            // 
            // femalePanel
            // 
            this.femalePanel.BackColor = System.Drawing.Color.Gold;
            this.femalePanel.Controls.Add(this.femaleLabel);
            this.femalePanel.Location = new System.Drawing.Point(400, 218);
            this.femalePanel.Name = "femalePanel";
            this.femalePanel.Size = new System.Drawing.Size(369, 152);
            this.femalePanel.TabIndex = 2;
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.totalLabel.Location = new System.Drawing.Point(73, 57);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(625, 64);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total Students:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.MouseEnter += new System.EventHandler(this.totalLabel_MouseEnter);
            this.totalLabel.MouseLeave += new System.EventHandler(this.totalLabel_MouseLeave);
            // 
            // maleLabel
            // 
            this.maleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.maleLabel.Location = new System.Drawing.Point(21, 49);
            this.maleLabel.Name = "maleLabel";
            this.maleLabel.Size = new System.Drawing.Size(346, 64);
            this.maleLabel.TabIndex = 0;
            this.maleLabel.Text = "Male:";
            this.maleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maleLabel.MouseEnter += new System.EventHandler(this.maleLabel_MouseEnter);
            this.maleLabel.MouseLeave += new System.EventHandler(this.maleLabel_MouseLeave);
            // 
            // femaleLabel
            // 
            this.femaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.femaleLabel.Location = new System.Drawing.Point(30, 49);
            this.femaleLabel.Name = "femaleLabel";
            this.femaleLabel.Size = new System.Drawing.Size(311, 64);
            this.femaleLabel.TabIndex = 0;
            this.femaleLabel.Text = "Female:";
            this.femaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.femaleLabel.MouseEnter += new System.EventHandler(this.femaleLabel_MouseEnter);
            this.femaleLabel.MouseLeave += new System.EventHandler(this.femaleLabel_MouseLeave);
            // 
            // StaticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 382);
            this.Controls.Add(this.malePanel);
            this.Controls.Add(this.femalePanel);
            this.Controls.Add(this.totalPanel);
            this.Name = "StaticsForm";
            this.Text = "StaticsForm";
            this.Load += new System.EventHandler(this.StaticsForm_Load);
            this.totalPanel.ResumeLayout(false);
            this.malePanel.ResumeLayout(false);
            this.femalePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel totalPanel;
        private System.Windows.Forms.Panel malePanel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Panel femalePanel;
        private System.Windows.Forms.Label maleLabel;
        private System.Windows.Forms.Label femaleLabel;
    }
}