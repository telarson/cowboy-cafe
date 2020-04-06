/* MenuItemSelectionControl.xaml.cs
 * Author: Tristan Larson
 */
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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {

        public MenuItemSelectionControl()
        {

            InitializeComponent();
            //Hook up events with handlers for entree buttons.
            AddCowpokeChiliButton.Click += OnIOrderItemButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnIOrderItemButtonClicked;
            AddAngryChickenButton.Click += OnIOrderItemButtonClicked;
            AddRustlersRibsButton.Click += OnIOrderItemButtonClicked;
            AddPecosPulledPorkButton.Click += OnIOrderItemButtonClicked;
            AddTrailBurgerButton.Click += OnIOrderItemButtonClicked;
            AddTexasTripleBurgerButton.Click += OnIOrderItemButtonClicked;

            //Hook up events with handlers for side buttons.
            AddChiliCheeseFries.Click += OnIOrderItemButtonClicked;
            AddCornDodgersButton.Click += OnIOrderItemButtonClicked;
            AddPanDeCampoButton.Click += OnIOrderItemButtonClicked;
            AddBakedBeansButton.Click += OnIOrderItemButtonClicked;

            //Hook up events with handlers for drink buttons.
            AddJerkedSodaButton.Click += OnIOrderItemButtonClicked;
            AddTexasTeaButton.Click += OnIOrderItemButtonClicked;
            AddCowboyCoffeeButton.Click += OnIOrderItemButtonClicked;
            AddWaterButton.Click += OnIOrderItemButtonClicked;

            
        }

        /// <summary>
        /// Generalized event handler for button IOrderItem button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnIOrderItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order CurrentOrder)
            {
                if(sender is Button button)
                {
                    switch (button.Tag)
                    {
                        case "CowpokeChili":
                            {
                                var item = new CowpokeChili();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "AngryChicken":
                            {
                                var item = new AngryChicken();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "DakotaDoubleBurger":
                            {
                                var item = new DakotaDoubleBurger();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "PecosPulledPork":
                            {
                                var item = new PecosPulledPork();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "RustlersRibs":
                            {
                                var item = new RustlersRibs();
                                CurrentOrder.Add(item);
                                break;
                            }
                        case "TexasTripleBurger":
                            {
                                var item = new TexasTripleBurger();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "TrailBurger":
                            {
                                var item = new TrailBurger();
                                var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "BakedBeans":
                            {
                                var item = new BakedBeans();
                                var screen = new CustomizeSide(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "ChiliCheeseFries":
                            {
                                var item = new ChiliCheeseFries();
                                var screen = new CustomizeSide(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "CornDodgers":
                            {
                                var item = new CornDodgers();
                                var screen = new CustomizeSide(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "PanDeCampo":
                            {
                                var item = new PanDeCampo();
                                var screen = new CustomizeSide(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "CowboyCoffee":
                            {
                                var item = new CowboyCoffee();
                                var screen = new CustomizeDrink(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "JerkedSoda":
                            {
                                var item = new JerkedSoda();
                                var screen = new CustomizeDrink(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "TexasTea":
                            {
                                var item = new TexasTea();
                                var screen = new CustomizeDrink(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "Water":
                            {
                                var item = new Water();
                                var screen = new CustomizeDrink(item);
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                    }
                }
            }
        }

    }
}
