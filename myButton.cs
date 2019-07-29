using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace OtheloFormAppUI
{
    class myButton : PictureBox
    {

       public myButton()
        {
            Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            SizeMode = PictureBoxSizeMode.StretchImage;
            BackColor = Color.Gold;
        }
    }
}
