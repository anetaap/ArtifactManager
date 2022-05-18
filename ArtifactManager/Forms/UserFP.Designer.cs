﻿using System.ComponentModel;

namespace ArtifactManager.Forms
{
    partial class UserFp
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
            this.topfive = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.Button();
            this.sign_out = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lastest = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.catalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topfive
            // 
            this.topfive.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.topfive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.topfive.FormattingEnabled = true;
            this.topfive.ItemHeight = 20;
            this.topfive.Location = new System.Drawing.Point(52, 253);
            this.topfive.Name = "topfive";
            this.topfive.Size = new System.Drawing.Size(832, 184);
            this.topfive.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(64, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(832, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "TOP 5 ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1079, 162);
            this.label1.TabIndex = 7;
            this.label1.Text = "Artifact  Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.profile.Location = new System.Drawing.Point(902, 171);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(133, 44);
            this.profile.TabIndex = 8;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = true;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // sign_out
            // 
            this.sign_out.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sign_out.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.sign_out.Location = new System.Drawing.Point(1064, 171);
            this.sign_out.Name = "sign_out";
            this.sign_out.Size = new System.Drawing.Size(133, 44);
            this.sign_out.TabIndex = 9;
            this.sign_out.Text = "Sign out";
            this.sign_out.UseVisualStyleBackColor = true;
            this.sign_out.Click += new System.EventHandler(this.sign_out_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Cambria", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(52, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(832, 44);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lastest added artifacts";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastest
            // 
            this.lastest.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.lastest.FormattingEnabled = true;
            this.lastest.ItemHeight = 20;
            this.lastest.Location = new System.Drawing.Point(52, 525);
            this.lastest.Name = "lastest";
            this.lastest.Size = new System.Drawing.Size(832, 184);
            this.lastest.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(839, 480);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.close.Location = new System.Drawing.Point(1122, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 29);
            this.close.TabIndex = 17;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // catalog
            // 
            this.catalog.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.catalog.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (238)));
            this.catalog.Location = new System.Drawing.Point(902, 253);
            this.catalog.Name = "catalog";
            this.catalog.Size = new System.Drawing.Size(295, 44);
            this.catalog.TabIndex = 18;
            this.catalog.Text = "Catalog";
            this.catalog.UseVisualStyleBackColor = true;
            this.catalog.Click += new System.EventHandler(this.catalog_Click);
            // 
            // UserFp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1209, 814);
            this.Controls.Add(this.catalog);
            this.Controls.Add(this.close);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lastest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign_out);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topfive);
            this.Controls.Add(this.label2);
            this.Name = "UserFp";
            this.Text = "Artifact  Manager";
            this.Load += new System.EventHandler(this.UserFp_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button catalog;

        private System.Windows.Forms.Button close;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.ListBox lastest;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button sign_out;

        private System.Windows.Forms.Button profile;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ListBox topfive;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}