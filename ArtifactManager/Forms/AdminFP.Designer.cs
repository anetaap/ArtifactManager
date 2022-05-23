using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class AdminFp
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
            this.login = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.changerole = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.ListBox();
            this.sign_out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.login.Location = new System.Drawing.Point(182, 155);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(963, 29);
            this.login.TabIndex = 37;
            this.login.Text = "Users";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1185, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(91, 29);
            this.close.TabIndex = 36;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(17, -27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1259, 182);
            this.label1.TabIndex = 34;
            this.label1.Text = "Artifact Manager Admin\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remove.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.remove.Location = new System.Drawing.Point(928, 624);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(217, 44);
            this.remove.TabIndex = 40;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.add_Click);
            // 
            // changerole
            // 
            this.changerole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.changerole.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.changerole.Location = new System.Drawing.Point(560, 624);
            this.changerole.Name = "changerole";
            this.changerole.Size = new System.Drawing.Size(217, 44);
            this.changerole.TabIndex = 39;
            this.changerole.Text = "Change Role";
            this.changerole.UseVisualStyleBackColor = true;
            this.changerole.Click += new System.EventHandler(this.remove_Click);
            // 
            // details
            // 
            this.details.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.details.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.details.Location = new System.Drawing.Point(182, 624);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(217, 44);
            this.details.TabIndex = 38;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.users.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.users.FormattingEnabled = true;
            this.users.ItemHeight = 20;
            this.users.Location = new System.Drawing.Point(182, 200);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(963, 384);
            this.users.TabIndex = 43;
            // 
            // sign_out
            // 
            this.sign_out.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sign_out.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.sign_out.Location = new System.Drawing.Point(1185, 59);
            this.sign_out.Name = "sign_out";
            this.sign_out.Size = new System.Drawing.Size(91, 29);
            this.sign_out.TabIndex = 44;
            this.sign_out.Text = "Sign out";
            this.sign_out.UseVisualStyleBackColor = true;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click);
            // 
            // AdminFp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1288, 711);
            this.Controls.Add(this.sign_out);
            this.Controls.Add(this.users);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.changerole);
            this.Controls.Add(this.details);
            this.Controls.Add(this.login);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label1);
            this.Name = "AdminFp";
            this.Text = "AdminFP";
            this.Load += new System.EventHandler(this.AdminFp_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button sign_out;

        private System.Windows.Forms.ListBox users;

        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button changerole;
        private System.Windows.Forms.Button details;

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}