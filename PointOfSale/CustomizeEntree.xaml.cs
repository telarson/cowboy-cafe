/* CustomizeEntree.xaml.cs
 * Author: Tristan Larson
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : UserControl
    {
        public CustomizeEntree(IOrderItem item)
        {
            InitializeComponent();

            DataContext = item;

            if (DataContext is IOrderItem currentItem)
            {
                AddCheckBoxesForBooleanProperties(currentItem);
            }
        }

        /// <summary>
        /// Dynamically adds check boxes to customize the order item.
        /// </summary>
        /// <param name="item"></param>
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
    }
}
