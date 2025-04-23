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
        public List<Button> AllButtons = new List<Button>();
        public int AmountOfHorizontalButtons = 3;
        public int AmountOfVerticalButtons = 3;
        public char currentSymbol = 'x';
        public MainWindow()
        {
            InitializeComponent();
            InitializeGameBoard();
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
                        PositionInGrid = positionInGrid,
                    };
                    //buttonToAdd.Click += Buttonclass.GetsClicked();

                    Grid.SetColumn(buttonToAdd, i);
                    Grid.SetRow(buttonToAdd, j);
                    MainGrid.Children.Add(buttonToAdd);
                    AllButtons.Add(buttonToAdd);
                    positionInGrid++;
                }
            }
        }
        public void ButtonClicked(object sender, RoutedEventArgs e)
        {
            Buttonclass senderButton = (Buttonclass)e.OriginalSource;
            
            senderButton.GetsClicked(senderButton, currentSymbol);
            
            Button clickedButton = sender as Button;
            string buttonContent = clickedButton.Content.ToString();  //macht string aus char
            if (clickedButton != null && string.IsNullOrEmpty(buttonContent))  //null überprüft ob überhauptein button existiert, string.IsNull... schaut ob der button leer ist, der string leer ist.
            {
                clickedButton.Content = currentSymbol;

                if(currentSymbol == 'x')
                {
                    currentSymbol = 'o';
                }
                else
                {
                    currentSymbol = 'x';
                }
            }

        }
    }
}
