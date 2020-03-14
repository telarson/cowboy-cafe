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

            largeButton.Click += OnSizeButtonClick;
            mediumButton.Click += OnSizeButtonClick;
            smallButton.Click += OnSizeButtonClick;

            largeButton.Click += RadioButtoner;
            mediumButton.Click += RadioButtoner;
            smallButton.Click += RadioButtoner;

        }

        /// <summary>
        /// Event handler for clicking the size buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnSizeButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Tag)
                {
                    case "Large":
                        if (DataContext is Side d)
                        {
                            d.Size = CowboyCafe.Data.Size.Large;
                        }
                        break;
                    case "Medium":
                        if (DataContext is Side f)
                        {
                            f.Size = CowboyCafe.Data.Size.Medium;
                        }
                        break;
                    case "Small":
                        if (DataContext is Side g)
                        {
                            g.Size = CowboyCafe.Data.Size.Small;
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Lets the sizee buttons act like radio buttons where the one selected will be unable to be pressed again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RadioButtoner(object sender, RoutedEventArgs e)
        {

            if (sender is Button b)
            {
                b.IsEnabled = false;
                foreach (UIElement element in SizeButtonPanel.Children)
                {
                    if (element is Button button)
                    {
                        if (button != sender as Button)
                        {
                            button.IsEnabled = true;
                        }
                    }
                }
            }
        }
    }
}
