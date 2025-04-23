using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_WPF
{
    class Buttonclass : System.Windows.Controls.Button
    {
        public int RowIndex;
        public int ColumnIndex;
        public int PositionInGrid;
        public bool CrossSymbol;
        public bool CircleSymbol;

        public Buttonclass()
        {

        }

        public void GetsClicked(Buttonclass Button)
        {
            string symbolToShow;
            //Button.IsPressed = true;
            Button.IsEnabled = false;

            if (CrossSymbol)
            {
                symbolToShow = "x";
            }
            if (CircleSymbol)
            {
                symbolToShow = "o";
            }
            else
            {
                symbolToShow = " ";
            }
            this.Content = symbolToShow;
        }
    }
}
