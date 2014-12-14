using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ScrollToAnElement_WP8.Resources;

namespace ScrollToAnElement_WP8
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

             LoadUiControls();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
     

        private void LoadUiControls()
        {
            for (int i = 0; i < 25; i++)
            {
                StackPanel.Children.Add(new TextBox(){Text = "Text"+(i+1)});
            }
        }

        private void ScrollToAnUiElement(UIElement uiElement)
        {
            GeneralTransform transform = uiElement.TransformToVisual(ScrollViewer);
            Point position = transform.Transform(new Point(0, 0));
            ScrollViewer.ScrollToVerticalOffset(position.Y);
        }

        private void ScrollButton(object sender, RoutedEventArgs e)
        {
            ScrollToAnUiElement(StackPanel.Children[12]); //zero based index. For 13th item it will be (n-1)=12
        }
    }
}