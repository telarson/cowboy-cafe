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
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;

            
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
                               //var screen = new CustomizeEntree(item as IOrderItem);
                                CurrentOrder.Add(item);
                                //orderControl.SwapScreen(screen);
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
                                var screen = new CustomizeSide();
                                screen.DataContext = item;
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "ChiliCheeseFries":
                            {
                                var item = new ChiliCheeseFries();
                                var screen = new CustomizeSide();
                                screen.DataContext = item;
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "CornDodgers":
                            {
                                var item = new CornDodgers();
                                var screen = new CustomizeSide();
                                screen.DataContext = item;
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                        case "PanDeCampo":
                            {
                                var item = new PanDeCampo();
                                var screen = new CustomizeSide();
                                screen.DataContext = item;
                                CurrentOrder.Add(item);
                                orderControl.SwapScreen(screen);
                                break;
                            }
                    }
                }
            }
        }

        /// <summary>
        /// Event handler for the AddCowpokeChili button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order CurrentOrder) 
            { 
                CurrentOrder.Add(new CowpokeChili());
                //orderControl.SwapScreen(new CustomizeEntree());
            }
        }

        /// <summary>
        /// Event handler for AddRustlersRibsButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order CurrentOrder)
                CurrentOrder.Add(new RustlersRibs());
        }

        /// <summary>
        /// Event handler for AddPecosPulledPorkButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Event handler for AddTrailBurgerButton Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new TrailBurger());
        }

        /// <summary>
        /// Event handler for the AddDakotaDoubleBurger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Event handler for the AddDakotaDoubleBurger button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Event handler for AddAngryChickenButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new AngryChicken());
        }

        /// <summary>
        /// Event handler for AddChiliCheeseFriesButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Event handler for AddCornDodgersButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new CornDodgers());
        }

        /// <summary>
        /// Event handler for AddPanDeCampoButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new PanDeCampo());
        }

        /// <summary>
        /// Event handler for AddBakedBeansButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new BakedBeans());
        }

        /// <summary>
        /// Event handler for AddJerkedSodaButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new JerkedSoda());
        }

        /// <summary>
        /// Event handler for AddTexasTeaButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new TexasTea());
        }

        /// <summary>
        /// Event handler for AddCowboyCoffeeButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Event handler for AddWaterButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new Water());
        }

    }
}
