using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace OtheloFormAppUI
{
    partial class setingChild
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
            this.shira = new OtheloFormAppUI.myButton();
            this.yahali = new OtheloFormAppUI.myButton();
            this.harel = new OtheloFormAppUI.myButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yahali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.harel)).BeginInit();
            this.SuspendLayout();
            // 
            // shira
            // 
            this.shira.BackColor = System.Drawing.Color.SandyBrown;
            this.shira.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.shira.Location = new System.Drawing.Point(31, 46);
            this.shira.Name = "shira";
            this.shira.Size = new System.Drawing.Size(178, 142);
            this.shira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.shira.TabIndex = 0;
            this.shira.TabStop = false;
            this.shira.Click += new System.EventHandler(this.shira_Click);
            // 
            // yahali
            // 
            this.yahali.BackColor = System.Drawing.Color.SandyBrown;
            this.yahali.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.yahali.Location = new System.Drawing.Point(292, 46);
            this.yahali.Name = "yahali";
            this.yahali.Size = new System.Drawing.Size(178, 142);
            this.yahali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yahali.TabIndex = 1;
            this.yahali.TabStop = false;
            this.yahali.Click += new System.EventHandler(this.yahali_Click);
            // 
            // harel
            // 
            this.harel.BackColor = System.Drawing.Color.SandyBrown;
            this.harel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.harel.Location = new System.Drawing.Point(165, 194);
            this.harel.Name = "harel";
            this.harel.Size = new System.Drawing.Size(178, 142);
            this.harel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.harel.TabIndex = 2;
            this.harel.TabStop = false;
            this.harel.Click += new System.EventHandler(this.harel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select player :)";
            // 
            // setingChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumVioletRed;
            this.ClientSize = new System.Drawing.Size(504, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.harel);
            this.Controls.Add(this.yahali);
            this.Controls.Add(this.shira);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "setingChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Nembers Game- Seting Child :)";
            this.Load += new System.EventHandler(this.setingChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yahali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.harel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myButton shira;
        private myButton yahali;
        private myButton harel;
        private System.Windows.Forms.Label label1;
    }
}