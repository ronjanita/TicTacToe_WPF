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
        public bool alreadyOpen = false;

        public Buttonclass(){}

        public void GetsClicked(Buttonclass clickedButton, char currentSymbol)
        {
            clickedButton.Content = currentSymbol;
            alreadyOpen = true;
            clickedButton.IsEnabled = false;
        }
    }
}
