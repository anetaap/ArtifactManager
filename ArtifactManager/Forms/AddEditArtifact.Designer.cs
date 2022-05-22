using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class AddEditArtifact
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
            this.attributes = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.discard = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.elements = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.attrType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(140, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1163, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Artiffact Type";
            // 
            // login
            // 
            this.login.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.login.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.login.Location = new System.Drawing.Point(140, 365);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(1163, 29);
            this.login.TabIndex = 36;
            this.login.Text = "Artifact Attributes";
            // 
            // attributes
            // 
            this.attributes.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attributes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.attributes.FormattingEnabled = true;
            this.attributes.Location = new System.Drawing.Point(140, 397);
            this.attributes.Name = "attributes";
            this.attributes.Size = new System.Drawing.Size(1163, 28);
            this.attributes.TabIndex = 35;
            this.attributes.SelectedIndexChanged += new System.EventHandler(this.attributes_SelectedIndexChanged);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1321, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 34;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 29);
            this.back.TabIndex = 33;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.title.Location = new System.Drawing.Point(0, -48);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1406, 182);
            this.title.TabIndex = 32;
            this.title.Text = "Artifact \r\n";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // value
            // 
            this.value.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.value.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.value.Location = new System.Drawing.Point(140, 589);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(1163, 27);
            this.value.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(140, 541);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1163, 29);
            this.label3.TabIndex = 39;
            this.label3.Text = "Attribute Value";
            // 
            // discard
            // 
            this.discard.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.discard.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.discard.Location = new System.Drawing.Point(140, 804);
            this.discard.Name = "discard";
            this.discard.Size = new System.Drawing.Size(1163, 43);
            this.discard.TabIndex = 42;
            this.discard.Text = "Discard Changes";
            this.discard.UseVisualStyleBackColor = true;
            this.discard.Click += new System.EventHandler(this.discard_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.save.Location = new System.Drawing.Point(140, 755);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(1163, 43);
            this.save.TabIndex = 41;
            this.save.Text = "Save Changes";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(140, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1163, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "Elements";
            // 
            // elements
            // 
            this.elements.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.elements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.elements.FormattingEnabled = true;
            this.elements.Location = new System.Drawing.Point(140, 315);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(1163, 28);
            this.elements.TabIndex = 43;
            this.elements.SelectedIndexChanged += new System.EventHandler(this.elements_SelectedIndexChanged);
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.name.Location = new System.Drawing.Point(140, 695);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(1163, 27);
            this.name.TabIndex = 46;
            // 
            // namelabel
            // 
            this.namelabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.namelabel.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.namelabel.Location = new System.Drawing.Point(140, 647);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(1163, 29);
            this.namelabel.TabIndex = 45;
            this.namelabel.Text = "Artifact Name";
            // 
            // attrType
            // 
            this.attrType.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.attrType.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.attrType.Location = new System.Drawing.Point(140, 490);
            this.attrType.Name = "attrType";
            this.attrType.Size = new System.Drawing.Size(1163, 27);
            this.attrType.TabIndex = 47;
            // 
            // AddEditArtifact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1408, 965);
            this.Controls.Add(this.attrType);
            this.Controls.Add(this.name);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.discard);
            this.Controls.Add(this.save);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.attributes);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.title);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AddEditArtifact";
            this.Load += new System.EventHandler(this.AddEditArtifact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox attrType;

        private System.Windows.Forms.Label namelabel;

        private System.Windows.Forms.TextBox name;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox elements;

        private System.Windows.Forms.Button discard;
        private System.Windows.Forms.Button save;

        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.ComboBox attributes;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label title;

        #endregion
    }
}