﻿using System;
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
            Showplayer.Text = "Welcome to TicTacToe, start game by pressing a button of your choice. x starts.";
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
                        PositionInGrid = positionInGrid
                    };
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
            Buttonclass clickedButton = (Buttonclass)e.OriginalSource;
            if (clickedButton == null) { return; }
            if (clickedButton.alreadyOpen == false)  //null überprüft ob überhauptein button existiert, string.IsNull... schaut ob der button leer ist, der string leer ist.
            {
                clickedButton.GetsClicked(clickedButton, currentSymbol);

                if(currentSymbol == 'x')
                {
                    currentSymbol = 'o';
                    Showplayer.Text = "current player: o";
                }
                else
                {
                    currentSymbol = 'x';
                    Showplayer.Text = "current player: x";
                }
            }
            CheckWin();
        }
        public bool CheckWin()
        {
            char?[] allButtons = new char?[AllButtons.Count];  //char array mit gleiocher länge wie anzahl buttons in AllButtons liste 
            Console.WriteLine(AllButtons);
            for (int i = 0; i < AllButtons.Count; i++)  //geht durch jeden Button und macht zeichen in ein char
            {
                allButtons[i] = (char?)AllButtons[i].Content;
            }
            for (int i = 0; i < 3; i++)  //Horizontale Überprüfung (Reihenweise)
            {
                if (allButtons[i * 3] == currentSymbol &&
                    allButtons[i * 3 + 1] == currentSymbol &&
                    allButtons[i * 3 + 2] == currentSymbol)
                {
                    Showwinner.Text = $"the winner is player {currentSymbol}. Congratulations!";
                    return true;
                }
            }
            for (int i = 0; i < 3; i++) // Vertikale Überprüfung (Spaltenweise)
            {
                if (allButtons[i] == currentSymbol &&

                    allButtons[i + 3] == currentSymbol &&
                    allButtons[i + 6] == currentSymbol)
                {
                    Showwinner.Text = $"the winner is player {currentSymbol}. Congratulations!";
                    return true;
                }
            }
            if (allButtons[0] == currentSymbol && // Diagonale Überprüfung (links oben nach rechts unten)
                allButtons[4] == currentSymbol &&
                allButtons[8] == currentSymbol)
            {
                Showwinner.Text = $"the winner is player {currentSymbol}. Congratulations!";
                return true;
            }
            if (allButtons[2] == currentSymbol && // Diagonale Überprüfung (rechts oben nach links unten)
                allButtons[4] == currentSymbol &&
                allButtons[6] == currentSymbol)
            {
                Showwinner.Text = $"the winner is player {currentSymbol}. Congratulations!";
                return true;
            }
            Showwinner.Text = "it's a draw. Noone won :(";
            return false; // Kein Gewinner, Unentschieden
        }
    }
}
