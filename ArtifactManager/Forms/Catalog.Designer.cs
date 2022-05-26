using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class Catalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mycategory = new System.Windows.Forms.ComboBox();
            this.artifact = new System.Windows.Forms.CheckedListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.attributes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1371, 182);
            this.label1.TabIndex = 17;
            this.label1.Text = "Artifact Catalog\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 26;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1283, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 27;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // category
            // 
            this.category.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(140, 194);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(1075, 24);
            this.category.TabIndex = 28;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(140, 162);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1075, 29);
            this.login.TabIndex = 29;
            this.login.Text = "Category";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(140, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1075, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Added Categories";
            // 
            // mycategory
            // 
            this.mycategory.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mycategory.FormattingEnabled = true;
            this.mycategory.Location = new System.Drawing.Point(140, 280);
            this.mycategory.Name = "mycategory";
            this.mycategory.Size = new System.Drawing.Size(1075, 24);
            this.mycategory.TabIndex = 30;
            this.mycategory.SelectedIndexChanged += new System.EventHandler(this.mycategory_SelectedIndexChanged);
            // 
            // artifact
            // 
            this.artifact.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.artifact.FormattingEnabled = true;
            this.artifact.Location = new System.Drawing.Point(140, 461);
            this.artifact.Name = "artifact";
            this.artifact.Size = new System.Drawing.Size(1075, 140);
            this.artifact.TabIndex = 32;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.add.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.add.Location = new System.Drawing.Point(998, 625);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(217, 44);
            this.add.TabIndex = 35;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.remove.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.remove.Location = new System.Drawing.Point(559, 625);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(217, 44);
            this.remove.TabIndex = 34;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // details
            // 
            this.details.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.details.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.details.Location = new System.Drawing.Point(140, 625);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(217, 44);
            this.details.TabIndex = 33;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.edit_Click);
            // 
            // attributes
            // 
            this.attributes.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.attributes.FormattingEnabled = true;
            this.attributes.ItemHeight = 20;
            this.attributes.Location = new System.Drawing.Point(140, 347);
            this.attributes.Name = "attributes";
            this.attributes.Size = new System.Drawing.Size(1075, 64);
            this.attributes.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(140, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1075, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "Category details";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(140, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1075, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Artifacts";
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1370, 773);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.details);
            this.Controls.Add(this.artifact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mycategory);
            this.Controls.Add(this.login);
            this.Controls.Add(this.category);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox attributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.CheckedListBox artifact;

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button details;

        private System.Windows.Forms.CheckedListBox artifacts;

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox mycategory;

        private System.Windows.Forms.ComboBox category;

        private System.Windows.Forms.Button close;

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}