using System.ComponentModel;

namespace ArtifactManager.Forms
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.change_passwd = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.lastname_ = new System.Windows.Forms.TextBox();
            this.name_ = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.discard = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1369, 162);
            this.label1.TabIndex = 14;
            this.label1.Text = "Profile details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1215, 12);
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
            this.edit.Location = new System.Drawing.Point(257, 528);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(217, 44);
            this.edit.TabIndex = 25;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // change_passwd
            // 
            this.change_passwd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.change_passwd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.change_passwd.Location = new System.Drawing.Point(527, 528);
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
            this.remove.Location = new System.Drawing.Point(813, 528);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(217, 44);
            this.remove.TabIndex = 27;
            this.remove.Text = "Remove profile";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.email.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.email.Location = new System.Drawing.Point(257, 427);
            this.email.Multiline = true;
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(773, 39);
            this.email.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(257, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.username.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.username.Location = new System.Drawing.Point(257, 341);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(773, 39);
            this.username.TabIndex = 33;
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.Location = new System.Drawing.Point(257, 299);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(684, 29);
            this.login.TabIndex = 32;
            this.login.Text = "Username ";
            // 
            // lastname_
            // 
            this.lastname_.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastname_.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lastname_.Location = new System.Drawing.Point(350, 243);
            this.lastname_.Multiline = true;
            this.lastname_.Name = "lastname_";
            this.lastname_.Size = new System.Drawing.Size(680, 39);
            this.lastname_.TabIndex = 31;
            // 
            // name_
            // 
            this.name_.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.name_.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.name_.Location = new System.Drawing.Point(257, 243);
            this.name_.Multiline = true;
            this.name_.Name = "name_";
            this.name_.Size = new System.Drawing.Size(680, 39);
            this.name_.TabIndex = 30;
            // 
            // lastname
            // 
            this.lastname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lastname.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lastname.Location = new System.Drawing.Point(656, 211);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(374, 29);
            this.lastname.TabIndex = 29;
            this.lastname.Text = "Last name";
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.name.Location = new System.Drawing.Point(257, 211);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(314, 29);
            this.name.TabIndex = 28;
            this.name.Text = "First name";
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.save.Location = new System.Drawing.Point(257, 603);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(773, 43);
            this.save.TabIndex = 36;
            this.save.Text = "Save Changes";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // discard
            // 
            this.discard.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discard.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.discard.Location = new System.Drawing.Point(257, 665);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(773, 43);
            this.discard.TabIndex = 37;
            this.discard.Text = "Discard Changes";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1302, 831);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.Controls.Add(this.lastname_);
            this.Controls.Add(this.name_);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.change_passwd);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button discard;

        private System.Windows.Forms.Button save;

        private System.Windows.Forms.TextBox name_;
        private System.Windows.Forms.TextBox lastname_;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox email;

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