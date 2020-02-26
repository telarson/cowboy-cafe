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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            //Hook up events with handlers for entree buttons.
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;

            //Hook up events with handlers for side buttons.
            AddChiliCheeseFries.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;

            //Hook up events with handlers for drink buttons.
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        /// <summary>
        /// Event handler for the AddCowpokeChili button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order CurrentOrder)
                CurrentOrder.Add(new CowpokeChili());
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
