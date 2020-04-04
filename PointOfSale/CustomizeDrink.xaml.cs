using System;
using System.Collections.Generic;
using System.Reflection;
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
using CowboyCafe.Extensions;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDrink.xaml
    /// </summary>
    public partial class CustomizeDrink : UserControl
    {
        public CustomizeDrink(IOrderItem item)
        {
            InitializeComponent();

            smallButton.Click += OnSizeButtonClick;
            mediumButton.Click += OnSizeButtonClick;
            largeButton.Click += OnSizeButtonClick;

            smallButton.Click += SizeRadioButtoner;
            mediumButton.Click += SizeRadioButtoner;
            largeButton.Click += SizeRadioButtoner;

            CreamSodaButton.Click += OnFlavorButtonClick;
            OrangeSodaButton.Click += OnFlavorButtonClick;
            SarsparillaButton.Click += OnFlavorButtonClick;
            BirchBeerButton.Click += OnFlavorButtonClick;
            RootBeerButton.Click += OnFlavorButtonClick;

            
            CreamSodaButton.Click += FlavorRadioButtoner;
            OrangeSodaButton.Click += FlavorRadioButtoner;
            SarsparillaButton.Click += FlavorRadioButtoner;
            BirchBeerButton.Click += FlavorRadioButtoner;
            RootBeerButton.Click += FlavorRadioButtoner;
            

            DataContext = item;

            if (DataContext is IOrderItem currentItem)
            {
                AddCheckBoxesForBooleanProperties(currentItem);

                if (currentItem is JerkedSoda j)
                {
                    switch (j.Flavor)
                    {
                        case SodaFlavor.CreamSoda:
                            CreamSodaButton.IsEnabled = false;
                            break;
                        case SodaFlavor.OrangeSoda:
                            OrangeSodaButton.IsEnabled = false;
                            break;
                        case SodaFlavor.Sarsparilla:
                            SarsparillaButton.IsEnabled = false;
                            break;
                        case SodaFlavor.BirchBeer:
                            BirchBeerButton.IsEnabled = false;
                            break;
                        case SodaFlavor.RootBeer:
                            RootBeerButton.IsEnabled = false;
                            break;
                    }
                    FlavorPanel.Visibility = Visibility.Visible;
                }
            }

            if (DataContext is Drink d)
            {
                switch (d.Size)
                {
                    case CowboyCafe.Data.Size.Small:
                        smallButton.IsEnabled = false;
                        break;
                    case CowboyCafe.Data.Size.Medium:
                        mediumButton.IsEnabled = false;
                        break;
                    case CowboyCafe.Data.Size.Large:
                        largeButton.IsEnabled = false;
                        break;
                }
            }

        }


        void AddCheckBoxesForBooleanProperties(IOrderItem item)
        {
            List<CheckBox> Controls = new List<CheckBox>();

            foreach (PropertyInfo prop in item.GetType().GetProperties())
            {
                if (prop.PropertyType == typeof(bool))
                {

                    Binding newBinding = new Binding(prop.Name);
                    newBinding.Source = item;

                    CheckBox newCheckBox = new CheckBox();
                    newCheckBox.Content = prop.Name;
                    newCheckBox.SetBinding(CheckBox.IsCheckedProperty, newBinding);

                    ScaleTransform scale = new ScaleTransform(2.0, 2.0);
                    newCheckBox.RenderTransform = scale;

                    Controls.Add(newCheckBox);
                }
            }

            CheckBoxList.ItemsSource = Controls;
        }

        /// <summary>
        /// Event handler for clicking the size buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSizeButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Tag)
                {
                    case "Large":
                        if (DataContext is Drink d)
                        {
                            d.Size = CowboyCafe.Data.Size.Large;
                        }
                        break;
                    case "Medium":
                        if (DataContext is Drink f)
                        {
                            f.Size = CowboyCafe.Data.Size.Medium;
                        }
                        break;
                    case "Small":
                        if (DataContext is Drink g)
                        {
                            g.Size = CowboyCafe.Data.Size.Small;
                        }
                        break;
                }
            }
        }


        void OnFlavorButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is JerkedSoda soda)
            {
                if (sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CreamSoda":
                            soda.Flavor = SodaFlavor.CreamSoda;
                            break;
                        case "OrangeSoda":
                            soda.Flavor = SodaFlavor.OrangeSoda;
                            break;
                        case "Sarsparilla":
                            soda.Flavor = SodaFlavor.Sarsparilla;
                            break;
                        case "BirchBeer":
                            soda.Flavor = SodaFlavor.BirchBeer;
                            break;
                        case "RootBeer":
                            soda.Flavor = SodaFlavor.RootBeer;
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Lets the size buttons act like radio buttons where the one selected will be unable to be pressed again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeRadioButtoner(object sender, RoutedEventArgs e)
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
        
        /// <summary>
        /// Lets the flavor buttons act like radio buttons where the one selected will be unable to be pressed again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FlavorRadioButtoner(object sender, RoutedEventArgs e)
        {
            if (sender is Button b)
            {
                b.IsEnabled = false;
                foreach (UIElement element in FlavorSelectionPanel.Children)
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
