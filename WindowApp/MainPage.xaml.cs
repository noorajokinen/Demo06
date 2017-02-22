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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WindowApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private int glassArea;
        private int windowArea;
        private int karmiPiiri;

        private void Calculate(object sender, RoutedEventArgs e)
        {
            int width = int.Parse(WidthBox.Text);
            int height = int.Parse(HeightBox.Text);
            int karmi = int.Parse(KarmiBox.Text);
            glassArea = (width-(2*karmi)*(height-(2*karmi)));
            GlassAreaBox.Text = glassArea.ToString(glassArea+" cm^2");
            windowArea = height*width;
            WindowAreaBox.Text = windowArea.ToString(windowArea+" cm^2");
            karmiPiiri = (2 * height) + (2 * width);
            KarmiAreaBox.Text = karmiPiiri.ToString(karmiPiiri+" cm");
        }
    }
}
