using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtheloFormAppUI
{
    public partial class setingChild : Form
    {
        int numOfChild;

        public setingChild()
        {
            InitializeComponent();
            shira.Image = Properties.Resources.shira;
            yahali.Image = Properties.Resources.yahali;
            harel.Image = Properties.Resources.Harel;
            this.ShowDialog();
        }

        public int NumOfChild { get => numOfChild;}

        private void setingChild_Load(object sender, EventArgs e)
        {

        }

        private void shira_Click(object sender, EventArgs e)
        {
            numOfChild = 0;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void yahali_Click(object sender, EventArgs e)
        {
            numOfChild = 1;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void harel_Click(object sender, EventArgs e)
        {
            numOfChild = 2;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
