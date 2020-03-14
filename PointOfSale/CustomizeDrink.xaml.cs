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
            
            DataContext = item;

            if (DataContext is IOrderItem currentItem)
            {
                AddCheckBoxesForBooleanProperties(currentItem);

                if (currentItem is JerkedSoda)
                {
                    FlavorPanel.Visibility = Visibility.Visible;
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

                    Controls.Add(newCheckBox);
                }
            }

            CheckBoxList.ItemsSource = Controls;
        }

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

        void OnLargeButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink d)
            {
                d.Size = CowboyCafe.Data.Size.Large;
            }
        }

        void OnMediumButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink d)
            {
                d.Size = CowboyCafe.Data.Size.Medium;
            }
        }

        void OnSmallButtonClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Drink d)
            {
                d.Size = CowboyCafe.Data.Size.Small;
            }
        }
    }
}
