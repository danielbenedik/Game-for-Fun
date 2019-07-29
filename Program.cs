using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OtheloFormAppUI;
namespace Ex05_OtheloFormsApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();

            setingChild newChild;
            FunGame Game;
            newChild = new setingChild();

            while (newChild.DialogResult == DialogResult.OK)
            {
             Game = new FunGame(newChild.NumOfChild);
                Game.StartGame();

             newChild = new setingChild();
            }


        }        
    }
}
