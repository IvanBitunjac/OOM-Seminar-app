namespace OOM_Seminar
{
    partial class Form1
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
            this.user1 = new OOM_Seminar.User();
            this.user2 = new OOM_Seminar.User();
            this.user3 = new OOM_Seminar.User();
            this.user4 = new OOM_Seminar.User();
            this.SuspendLayout();
            // 
            // user1
            // 
            this.user1.Location = new System.Drawing.Point(12, 12);
            this.user1.Name = "user1";
            this.user1.Size = new System.Drawing.Size(338, 139);
            this.user1.TabIndex = 0;
            // 
            // user2
            // 
            this.user2.Location = new System.Drawing.Point(423, 12);
            this.user2.Name = "user2";
            this.user2.Size = new System.Drawing.Size(352, 139);
            this.user2.TabIndex = 1;
            // 
            // user3
            // 
            this.user3.Location = new System.Drawing.Point(12, 223);
            this.user3.Name = "user3";
            this.user3.Size = new System.Drawing.Size(338, 139);
            this.user3.TabIndex = 2;
            // 
            // user4
            // 
            this.user4.Location = new System.Drawing.Point(423, 223);
            this.user4.Name = "user4";
            this.user4.Size = new System.Drawing.Size(338, 139);
            this.user4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 508);
            this.Controls.Add(this.user4);
            this.Controls.Add(this.user3);
            this.Controls.Add(this.user2);
            this.Controls.Add(this.user1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private User user1;
        private User user2;
        private User user3;
        private User user4;
    }
}

