using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace PopupAndInAppnitificationZIndex
{
    public sealed partial class MyUserControl : UserControl
    {
        Popup popup;

        public MyUserControl()
        {
            this.InitializeComponent();
            this.Width = Window.Current.Bounds.Width;
            this.Height = Window.Current.Bounds.Height;

            popup = new Popup();
            popup.Child = this;
        }

        public void Show()
        {
            popup.IsOpen = true;
        }

        public void Hide()
        {
            popup.IsOpen = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
        }
    }
}
