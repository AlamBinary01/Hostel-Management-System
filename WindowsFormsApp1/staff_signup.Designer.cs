﻿
namespace WindowsFormsApp1
{
    partial class staff_signup
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.stlogin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.student_password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.student_username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.previous;
            this.pictureBox2.Location = new System.Drawing.Point(27, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.sign_up;
            this.pictureBox1.Location = new System.Drawing.Point(62, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel1.Controls.Add(this.stlogin_btn);
            this.panel1.Controls.Add(this.student_password);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.student_username);
            this.panel1.Location = new System.Drawing.Point(-1, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 260);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "CNIC";
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "ID Card Number";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(366, 149);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(302, 44);
            this.bunifuMaterialTextbox1.TabIndex = 20;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // stlogin_btn
            // 
            this.stlogin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.stlogin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.stlogin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.stlogin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.stlogin_btn.FillColor = System.Drawing.Color.OrangeRed;
            this.stlogin_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stlogin_btn.ForeColor = System.Drawing.Color.Black;
            this.stlogin_btn.Location = new System.Drawing.Point(587, 205);
            this.stlogin_btn.Name = "stlogin_btn";
            this.stlogin_btn.Size = new System.Drawing.Size(107, 42);
            this.stlogin_btn.TabIndex = 19;
            this.stlogin_btn.Text = "Sign up";
            this.stlogin_btn.Click += new System.EventHandler(this.stlogin_btn_Click);
            // 
            // student_password
            // 
            this.student_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.student_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_password.HintForeColor = System.Drawing.Color.Empty;
            this.student_password.HintText = "Password";
            this.student_password.isPassword = true;
            this.student_password.LineFocusedColor = System.Drawing.Color.Brown;
            this.student_password.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.student_password.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.student_password.LineThickness = 3;
            this.student_password.Location = new System.Drawing.Point(366, 93);
            this.student_password.Margin = new System.Windows.Forms.Padding(4);
            this.student_password.Name = "student_password";
            this.student_password.Size = new System.Drawing.Size(302, 44);
            this.student_password.TabIndex = 18;
            this.student_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(246, 118);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(80, 19);
            this.Password.TabIndex = 16;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "User Name";
            // 
            // student_username
            // 
            this.student_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.student_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.student_username.HintForeColor = System.Drawing.Color.Empty;
            this.student_username.HintText = "Username";
            this.student_username.isPassword = false;
            this.student_username.LineFocusedColor = System.Drawing.Color.Brown;
            this.student_username.LineIdleColor = System.Drawing.Color.OrangeRed;
            this.student_username.LineMouseHoverColor = System.Drawing.Color.Brown;
            this.student_username.LineThickness = 3;
            this.student_username.Location = new System.Drawing.Point(366, 30);
            this.student_username.Margin = new System.Windows.Forms.Padding(4);
            this.student_username.Name = "student_username";
            this.student_username.Size = new System.Drawing.Size(302, 44);
            this.student_username.TabIndex = 14;
            this.student_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(243, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 32);
            this.label4.TabIndex = 31;
            this.label4.Text = "Staff Sign UP";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // staff_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(730, 375);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff_signup";
            this.Text = "staff_signup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button stlogin_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_password;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox student_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}