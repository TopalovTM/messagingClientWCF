﻿namespace managerClient
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.btBlockUser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btGetUsers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 16;
            this.lbUsers.Location = new System.Drawing.Point(8, 23);
            this.lbUsers.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(207, 164);
            this.lbUsers.TabIndex = 1;
            // 
            // btBlockUser
            // 
            this.btBlockUser.Location = new System.Drawing.Point(119, 196);
            this.btBlockUser.Margin = new System.Windows.Forms.Padding(4);
            this.btBlockUser.Name = "btBlockUser";
            this.btBlockUser.Size = new System.Drawing.Size(100, 28);
            this.btBlockUser.TabIndex = 2;
            this.btBlockUser.Text = "Block user";
            this.btBlockUser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btGetUsers);
            this.groupBox1.Controls.Add(this.lbUsers);
            this.groupBox1.Controls.Add(this.btBlockUser);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(227, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage users";
            // 
            // btGetUsers
            // 
            this.btGetUsers.Location = new System.Drawing.Point(8, 196);
            this.btGetUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btGetUsers.Name = "btGetUsers";
            this.btGetUsers.Size = new System.Drawing.Size(100, 28);
            this.btGetUsers.TabIndex = 0;
            this.btGetUsers.Text = "Get users";
            this.btGetUsers.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btBlockUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGetUsers;
    }
}

