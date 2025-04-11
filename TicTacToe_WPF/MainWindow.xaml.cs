using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Button> Button = new List<Button>();
        public int AmountOfHorizontalButtons;
        public int AmountOfVerticalButtons;
        public MainWindow()
        {
            InitializeComponent();
        }
        public void InitializeGameBoard()
        {
            int positionInGrid = 0;
            for (int j = 0; j < AmountOfVerticalButtons;  j++)
            {
                for (int i = 0; i < AmountOfHorizontalButtons; i++)
                {
                    Buttonclass buttonToAdd = new Buttonclass
                    {
                        Name = "Button" + (j * AmountOfHorizontalButtons + i).ToString(),
                        RowIndex = j,
                        ColumnIndex= i,
                    };
                    Button.Add(buttonToAdd);
                    positionInGrid++;
                }
            }
        }
    }
}
