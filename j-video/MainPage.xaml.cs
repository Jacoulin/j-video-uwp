using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace j_video
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // using Windows.UI.ViewManagement;

            var titleBar = ApplicationView.GetForCurrentView().TitleBar;

            // Set active window colors
            titleBar.ForegroundColor = Colors.White;
            titleBar.BackgroundColor = Color.FromArgb(1,186, 34, 38);
            titleBar.ButtonForegroundColor = Colors.White;
            titleBar.ButtonBackgroundColor = Color.FromArgb(1, 186, 34, 38);
            titleBar.ButtonHoverForegroundColor = Colors.White;
            titleBar.ButtonHoverBackgroundColor = Color.FromArgb(1, 186, 80, 80);
            titleBar.ButtonPressedForegroundColor = Colors.Gray;
            titleBar.ButtonPressedBackgroundColor = Color.FromArgb(1, 186, 50, 50);

            // Set inactive window colors
            titleBar.InactiveForegroundColor = Colors.Gray;
            titleBar.InactiveBackgroundColor = Color.FromArgb(1, 186, 34, 38);
            titleBar.ButtonInactiveForegroundColor = Colors.Gray;
            titleBar.ButtonInactiveBackgroundColor = Color.FromArgb(1, 186, 34, 38);

        }
    }
}
