using System;

namespace OOM_Seminar
{
    partial class User
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox_previousMessages = new System.Windows.Forms.ListBox();
            this.checkbox_Active = new System.Windows.Forms.CheckBox();
            this.txtbox_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox_previousMessages
            // 
            this.listbox_previousMessages.FormattingEnabled = true;
            this.listbox_previousMessages.Location = new System.Drawing.Point(18, 35);
            this.listbox_previousMessages.Name = "listbox_previousMessages";
            this.listbox_previousMessages.Size = new System.Drawing.Size(211, 56);
            this.listbox_previousMessages.TabIndex = 0;
            // 
            // checkbox_Active
            // 
            this.checkbox_Active.AutoSize = true;
            this.checkbox_Active.Location = new System.Drawing.Point(18, 12);
            this.checkbox_Active.Name = "checkbox_Active";
            this.checkbox_Active.Size = new System.Drawing.Size(56, 17);
            this.checkbox_Active.TabIndex = 1;
            this.checkbox_Active.Text = "Active";
            this.checkbox_Active.UseVisualStyleBackColor = true;
            // 
            // txtbox_Message
            // 
            this.txtbox_Message.Location = new System.Drawing.Point(18, 97);
            this.txtbox_Message.Name = "txtbox_Message";
            this.txtbox_Message.Size = new System.Drawing.Size(211, 20);
            this.txtbox_Message.TabIndex = 2;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(235, 94);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 3;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txtbox_Message);
            this.Controls.Add(this.checkbox_Active);
            this.Controls.Add(this.listbox_previousMessages);
            this.Name = "User";
            this.Size = new System.Drawing.Size(365, 144);
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void User_Load(object sender, EventArgs e)
        {
           
        }

        #endregion

        private System.Windows.Forms.ListBox listbox_previousMessages;
        private System.Windows.Forms.CheckBox checkbox_Active;
        private System.Windows.Forms.TextBox txtbox_Message;
        private System.Windows.Forms.Button btn_Send;
    }
}
