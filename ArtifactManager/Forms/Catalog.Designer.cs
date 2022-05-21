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
            this.edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(1, -33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1259, 182);
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
            this.close.Location = new System.Drawing.Point(1171, 12);
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
            this.category.Location = new System.Drawing.Point(140, 181);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(963, 24);
            this.category.TabIndex = 28;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.Location = new System.Drawing.Point(140, 149);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(963, 29);
            this.login.TabIndex = 29;
            this.login.Text = "Category";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(140, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(963, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Added Categories";
            // 
            // mycategory
            // 
            this.mycategory.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mycategory.FormattingEnabled = true;
            this.mycategory.Location = new System.Drawing.Point(140, 267);
            this.mycategory.Name = "mycategory";
            this.mycategory.Size = new System.Drawing.Size(963, 24);
            this.mycategory.TabIndex = 30;
            this.mycategory.SelectedIndexChanged += new System.EventHandler(this.mycategory_SelectedIndexChanged);
            // 
            // artifact
            // 
            this.artifact.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.artifact.FormattingEnabled = true;
            this.artifact.Location = new System.Drawing.Point(140, 345);
            this.artifact.Name = "artifact";
            this.artifact.Size = new System.Drawing.Size(963, 208);
            this.artifact.TabIndex = 32;
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.add.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.add.Location = new System.Drawing.Point(886, 577);
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
            this.remove.Location = new System.Drawing.Point(503, 577);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(217, 44);
            this.remove.TabIndex = 34;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.edit.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.edit.Location = new System.Drawing.Point(140, 577);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(217, 44);
            this.edit.TabIndex = 33;
            this.edit.Text = "Edit";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1258, 677);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
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

        private System.Windows.Forms.CheckedListBox artifact;

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button edit;

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