using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OtheloFormAppUI
{
    partial class FunGame
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
            this.num1 = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.child = new OtheloFormAppUI.myButton();
            ((System.ComponentModel.ISupportInitialize)(this.child)).BeginInit();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.num1.Enabled = false;
            this.num1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.num1.Location = new System.Drawing.Point(358, 28);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(128, 105);
            this.num1.TabIndex = 0;
            this.num1.UseVisualStyleBackColor = false;
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sign.Enabled = false;
            this.sign.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.sign.Location = new System.Drawing.Point(492, 62);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(60, 42);
            this.sign.TabIndex = 1;
            this.sign.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(771, 62);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 47);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.num2.Enabled = false;
            this.num2.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.num2.Location = new System.Drawing.Point(558, 28);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(128, 105);
            this.num2.TabIndex = 4;
            this.num2.UseVisualStyleBackColor = false;
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Equal.Enabled = false;
            this.Equal.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.Equal.Location = new System.Drawing.Point(692, 66);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(58, 38);
            this.Equal.TabIndex = 6;
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Text = "=";
            // 
            // child
            // 
            this.child.BackColor = System.Drawing.Color.SandyBrown;
            this.child.Enabled = false;
            this.child.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.child.Location = new System.Drawing.Point(82, 12);
            this.child.Name = "child";
            this.child.Size = new System.Drawing.Size(155, 150);
            this.child.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.child.TabIndex = 7;
            this.child.TabStop = false;
            // 
            // FunGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(977, 372);
            this.Controls.Add(this.child);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.num1);
            this.MaximizeBox = false;
            this.Name = "FunGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Numbers Game";
            ((System.ComponentModel.ISupportInitialize)(this.child)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button Equal;
        private myButton child;
    }
}