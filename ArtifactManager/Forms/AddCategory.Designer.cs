using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class AddCategory
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
            this.categoryname = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.types = new System.Windows.Forms.ComboBox();
            this.attributes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.attributename = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, -79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1192, 182);
            this.label1.TabIndex = 18;
            this.label1.Text = "Create New Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // categoryname
            // 
            this.categoryname.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryname.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.categoryname.Location = new System.Drawing.Point(204, 171);
            this.categoryname.Multiline = true;
            this.categoryname.Name = "categoryname";
            this.categoryname.Size = new System.Drawing.Size(773, 39);
            this.categoryname.TabIndex = 35;
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login.Location = new System.Drawing.Point(204, 129);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(684, 29);
            this.login.TabIndex = 34;
            this.login.Text = "Category name";
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.create.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.create.Location = new System.Drawing.Point(207, 623);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(773, 43);
            this.create.TabIndex = 37;
            this.create.Text = "Create ";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.add.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.add.Location = new System.Drawing.Point(204, 563);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(755, 44);
            this.add.TabIndex = 39;
            this.add.Text = "Add Attribute";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.remove.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.remove.Location = new System.Drawing.Point(225, 563);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(755, 44);
            this.remove.TabIndex = 38;
            this.remove.Text = " Remove Attribute";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(204, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Attribute type";
            // 
            // types
            // 
            this.types.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.types.FormattingEnabled = true;
            this.types.Location = new System.Drawing.Point(204, 261);
            this.types.Name = "types";
            this.types.Size = new System.Drawing.Size(773, 24);
            this.types.TabIndex = 41;
            // 
            // attributes
            // 
            this.attributes.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.attributes.FormattingEnabled = true;
            this.attributes.ItemHeight = 20;
            this.attributes.Location = new System.Drawing.Point(207, 404);
            this.attributes.Name = "attributes";
            this.attributes.Size = new System.Drawing.Size(773, 144);
            this.attributes.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(207, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(684, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Attribute type";
            // 
            // attributename
            // 
            this.attributename.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attributename.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.attributename.Location = new System.Drawing.Point(204, 346);
            this.attributename.Multiline = true;
            this.attributename.Name = "attributename";
            this.attributename.Size = new System.Drawing.Size(773, 39);
            this.attributename.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(204, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(684, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Attribute  name";
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 46;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1106, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 47;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1193, 716);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.attributename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.types);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.create);
            this.Controls.Add(this.categoryname);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button close;

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.ListBox attributes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox attributename;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.ComboBox types;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;

        private System.Windows.Forms.Button create;

        private System.Windows.Forms.TextBox categoryname;
        private System.Windows.Forms.Label login;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}