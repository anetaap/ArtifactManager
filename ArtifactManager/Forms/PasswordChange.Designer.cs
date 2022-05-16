using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class PasswordChange
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
            this.change_passwd = new System.Windows.Forms.Button();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.password1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.Location = new System.Drawing.Point(-199, 29);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 17;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(4, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1150, 182);
            this.label1.TabIndex = 16;
            this.label1.Text = "Change password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_passwd
            // 
            this.change_passwd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.change_passwd.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.change_passwd.Location = new System.Drawing.Point(231, 454);
            this.change_passwd.Name = "change_passwd";
            this.change_passwd.Size = new System.Drawing.Size(687, 43);
            this.change_passwd.TabIndex = 20;
            this.change_passwd.Text = "Change password";
            this.change_passwd.UseVisualStyleBackColor = true;
            this.change_passwd.Click += new System.EventHandler(this.change_passwd_Click);
            // 
            // password2
            // 
            this.password2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.password2.Location = new System.Drawing.Point(231, 378);
            this.password2.Multiline = true;
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(687, 39);
            this.password2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(231, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(687, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Repeat password";
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.password.Location = new System.Drawing.Point(231, 187);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(687, 39);
            this.password.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(231, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(687, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Current password";
            // 
            // password1
            // 
            this.password1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.password1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.password1.Location = new System.Drawing.Point(231, 289);
            this.password1.Multiline = true;
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(687, 39);
            this.password1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(231, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(687, 36);
            this.label4.TabIndex = 23;
            this.label4.Text = "New password";
            // 
            // back_
            // 
            this.back_.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back_.Location = new System.Drawing.Point(12, 12);
            this.back_.Name = "back_";
            this.back_.Size = new System.Drawing.Size(75, 29);
            this.back_.TabIndex = 25;
            this.back_.Text = "Back";
            this.back_.UseVisualStyleBackColor = true;
            this.back_.Click += new System.EventHandler(this.back__Click);
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1166, 559);
            this.Controls.Add(this.back_);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.change_passwd);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.Load += new System.EventHandler(this.PasswordChange_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button back_;

        private System.Windows.Forms.Button change_passwd;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}