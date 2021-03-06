﻿using Exercise2;
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

namespace Labsheet8V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ComputerGameData db = new ComputerGameData();
        string URL = @"C:\Users\David\Documents\GitHub\LabSheet8V2\Labsheet8V2\Labsheet8V2\Images\";

        public MainWindow()
        {
            InitializeComponent();
        }



        private void LbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComputerGame selectedItem = LbxGames.SelectedItem as ComputerGame;

            if(selectedItem != null)
            {
                var quer1 = from g in db.Characters
                            where g.ID.Equals(selectedItem.ID)
                            select g;

                LbxCharacterList.ItemsSource = quer1.ToList();
            }

            
        }

        private void LbxCharacterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character selecteditem = LbxCharacterList.SelectedItem as Character;

            if(selecteditem != null)
            {
                Image.Fill = new ImageBrush(new BitmapImage(new Uri(URL + selecteditem.CharacterImage + ".jpg", UriKind.Relative)));
            }

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from g in db.Games
                        select g;

            LbxGames.ItemsSource = query.ToList();
        }
    }
}
