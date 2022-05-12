using System.ComponentModel;

namespace ArtifactManager
{
    partial class UserProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label2 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.change_passwd = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.name_ = new System.Windows.Forms.Label();
            this.lastname_ = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(257, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Email";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.Location = new System.Drawing.Point(257, 288);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(708, 29);
            this.login.TabIndex = 20;
            this.login.Text = "Username ";
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastname.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastname.Location = new System.Drawing.Point(655, 199);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(310, 29);
            this.lastname.TabIndex = 17;
            this.lastname.Text = "Last name";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.name.Location = new System.Drawing.Point(257, 199);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(338, 29);
            this.name.TabIndex = 16;
            this.name.Text = "First name";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(-22, -39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1276, 162);
            this.label1.TabIndex = 14;
            this.label1.Text = "Profile details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1122, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 24;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.edit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.edit.Location = new System.Drawing.Point(257, 523);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(217, 44);
            this.edit.TabIndex = 25;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            // 
            // change_passwd
            // 
            this.change_passwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.change_passwd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.change_passwd.Location = new System.Drawing.Point(506, 523);
            this.change_passwd.Name = "change_passwd";
            this.change_passwd.Size = new System.Drawing.Size(217, 44);
            this.change_passwd.TabIndex = 26;
            this.change_passwd.Text = "Change password";
            this.change_passwd.UseVisualStyleBackColor = true;
            this.change_passwd.Click += new System.EventHandler(this.change_passwd_Click);
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remove.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.remove.Location = new System.Drawing.Point(748, 523);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(217, 44);
            this.remove.TabIndex = 27;
            this.remove.Text = "Remove profile";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // name_
            // 
            this.name_.Location = new System.Drawing.Point(257, 228);
            this.name_.Name = "name_";
            this.name_.Size = new System.Drawing.Size(680, 39);
            this.name_.TabIndex = 28;
            // 
            // lastname_
            // 
            this.lastname_.Location = new System.Drawing.Point(270, 228);
            this.lastname_.Name = "lastname_";
            this.lastname_.Size = new System.Drawing.Size(680, 39);
            this.lastname_.TabIndex = 29;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(257, 317);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(680, 39);
            this.username.TabIndex = 30;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(257, 412);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(680, 39);
            this.email.TabIndex = 31;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 821);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Controls.Add(this.lastname_);
            this.Controls.Add(this.name_);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.change_passwd);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label name_;
        private System.Windows.Forms.Label lastname_;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;

        private System.Windows.Forms.Button remove;

        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button change_passwd;

        private System.Windows.Forms.Button close;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}