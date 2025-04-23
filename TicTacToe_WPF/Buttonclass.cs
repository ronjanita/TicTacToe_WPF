using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TicTacToe_WPF
{
    class Buttonclass : System.Windows.Controls.Button
    {
        public int RowIndex;
        public int ColumnIndex;
        public int PositionInGrid;

        public Buttonclass()
        {

        }
        public void GetsClicked(Buttonclass clickedButton, char currentSymbol)
        {
            clickedButton.Content = currentSymbol;

            //string symbolToShow;
            //Button.IsPressed = true;
            //Button.IsEnabled = false;


            //if (CrossSymbol)
            //{
            //    symbolToShow = "x";
            //}
            //if (CircleSymbol)
            //{
            //    symbolToShow = "o";
            //}
            //else
            //{
            //    symbolToShow = " ";
            //}
            //Button.Content = symbolToShow;
        }
    }
}
