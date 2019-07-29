using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OtheloFormAppUI
{
    public partial class FunGame : Form
    {
        int[] arry = { 0, 1, 2, 3, 4};
        string[] sighArry = { "+", "-" };
        int sizeQ = 6;
        myButton[] ButtonArry;
        Random RandomNum;
        int Xnum, Ynum;
        int sumOfAnswer;
        bool currectAnswer = true;
        int m_childNum;
        DialogResult enaderRauond = DialogResult.No;
        PictureBox saveGoodPic;
        PictureBox savebadPic;


        public FunGame(int childNum)
        {
            InitializeComponent();

            m_childNum = childNum;
            ButtonArry = new myButton[sizeQ];
            SetUpButton();

            saveGoodPic = new PictureBox();
            savebadPic = new PictureBox();
            setchildPicNum(childNum);
            this.RandomNum = new Random();
        }
        
        private void setchildPicNum(int childNum)
        {
            switch (childNum)
            {
                case 0:
                    child.Image = Properties.Resources.shira;
                    saveGoodPic.Image = Properties.Resources._1151573085;
                    savebadPic.Image = Properties.Resources.shirahadash;
                    break;
                case 1:
                    child.Image = Properties.Resources.yahali;
                    saveGoodPic.Image = Properties.Resources._1151573085;
                    savebadPic.Image = Properties.Resources.little_x5;
                    break;
                case 2:
                    child.Image = Properties.Resources.Harel;
                    saveGoodPic.Image = Properties.Resources.zombi;
                    savebadPic.Image = Properties.Resources.badM;
                    break;
                default:
                    break;
            }
        }

        public void StartGame()
        {
            do
            {
                sumOfAnswer = 0;
                updateDataTest();
                this.ShowDialog();
                startOver();
            } while (enaderRauond == DialogResult.Yes && this.DialogResult == DialogResult.OK);

        }
        private void startOver()
        {
            for(int i=0; i< ButtonArry.Length; i++)
            {
                ButtonArry[i].Image = null;
                ButtonArry[i].BackColor = Color.Gold;
            }
        }
        private void updateDataTest()
        {
            Xnum = arry[RandomNum.Next(arry.Length)];
            Ynum = arry[RandomNum.Next(arry.Length)];

            this.num1.Text = Xnum.ToString();
            this.num2.Text = Ynum.ToString();
            this.sign.Text = sighArry[RandomNum.Next(sighArry.Length)];

            if(sign.Text == "-")
            {
                if(Xnum<Ynum)
                {
                    Xnum += ((Ynum-Xnum)+arry[RandomNum.Next(arry.Length)]);
                    this.num1.Text = Xnum.ToString();
                }
            }
            ButtonArry[sumOfAnswer].Image = Properties.Resources.Q;
        }

        private void SetUpButton()
        {
            for (int i=0; i< ButtonArry.Length; i++)
            {
                ButtonArry[i] = new myButton();
                ButtonArry[i].Enabled = false;
                this.Controls.Add(ButtonArry[i]);
                ButtonArry[i].Location = new System.Drawing.Point(12+i*120,150);
                ButtonArry[i].Size = new System.Drawing.Size(110,110);
            }

        }

    

        private void UpdateRus()
        {
            ButtonArry[sumOfAnswer].BackColor = Color.Empty;
            if(currectAnswer == true)
            {
                ButtonArry[sumOfAnswer].Image = saveGoodPic.Image;
                sumOfAnswer++;
            }
            else
            {
                ButtonArry[sumOfAnswer].Image = savebadPic.Image;
            }

        }

        private bool CheckEndGame()
        {
            if(sumOfAnswer == sizeQ)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                enaderRauond = endGameDialog();
                return true;

            }
            return false;
        }

        private void CheckAnswer()
        {
            int enswer=0;
            switch (this.sign.Text)
            {
                case "+":
                    enswer = Xnum + Ynum;
                    break;
                case "-":
                    enswer = Xnum - Ynum;
                    break;
                default:
                    break;
            }
            int enswerNum;
            bool isNum = int.TryParse(textBox1.Text, out enswerNum);
            if (enswerNum == enswer && isNum == true)
            {
                currectAnswer = true;
            }
            else
            {
                currectAnswer = false;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
                UpdateRus();
                if (currectAnswer)
                {
                    if (!CheckEndGame())
                    {
                       updateDataTest();
                    }
                }
                textBox1.Text = string.Empty;
            }
        }

        private DialogResult endGameDialog()
        {
            string title = "Fun Numbers Game";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            return MessageBox.Show(" Your success, well done! :)  you want another game?", title, buttons, icon);
        }
    }
}
