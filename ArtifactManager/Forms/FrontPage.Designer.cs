namespace ArtifactManager.Forms
{
    partial class FrontPage
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
            this.sign_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sign_up = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.counter = new System.Windows.Forms.ComboBox();
            this.lastest = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sign_in.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.sign_in.Location = new System.Drawing.Point(1105, 149);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(133, 44);
            this.sign_in.TabIndex = 0;
            this.sign_in.Text = "Login";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria Math", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.label1.Location = new System.Drawing.Point(27, -52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1379, 162);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artifact  Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sign_up
            // 
            this.sign_up.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sign_up.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.sign_up.Location = new System.Drawing.Point(1258, 149);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(133, 44);
            this.sign_up.TabIndex = 2;
            this.sign_up.Text = "Register";
            this.sign_up.UseVisualStyleBackColor = true;
            this.sign_up.Click += new System.EventHandler(this.sign_up_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(27, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(722, 44);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOP 5 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(27, 210);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(832, 260);
            this.listBox1.TabIndex = 4;
            // 
            // counter
            // 
            this.counter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.counter.FormattingEnabled = true;
            this.counter.Location = new System.Drawing.Point(1193, 537);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(45, 24);
            this.counter.TabIndex = 15;
            this.counter.SelectedIndexChanged += new System.EventHandler(this.counter_SelectedIndexChanged);
            // 
            // lastest
            // 
            this.lastest.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lastest.FormattingEnabled = true;
            this.lastest.ItemHeight = 20;
            this.lastest.Location = new System.Drawing.Point(27, 576);
            this.lastest.Name = "lastest";
            this.lastest.Size = new System.Drawing.Size(832, 264);
            this.lastest.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(27, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lastest added artifacts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1408, 888);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.lastest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sign_up);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_in);
            this.Name = "FrontPage";
            this.Text = "Artifact  Manager";
            this.Load += new System.EventHandler(this.FrontPage_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox counter;
        private System.Windows.Forms.ListBox lastest;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ListBox listBox1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button sign_up;

        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}