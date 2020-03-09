using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSide.xaml
    /// </summary>
    public partial class CustomizeSide : UserControl
    {
        public CustomizeSide()
        {
            InitializeComponent();

            largeButton.Click += OnLargeButtonClick;
            mediumButton.Click += OnMediumButtonClick;
            smallButton.Click += OnSmallButtonClick;

        }

        void OnLargeButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Side s)
            {
                s.Size = CowboyCafe.Data.Size.Large;
            }
        }

        void OnMediumButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side s)
            {
                s.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        void OnSmallButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Side s)
            {
                s.Size = CowboyCafe.Data.Size.Small;
            }
        }
    }
}
