using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Slavin_glas_UWP.SlavinGlas.Views.BaseMedia
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RadioPage : Page
    {
        public RadioPage()
        {
            this.InitializeComponent();
            
            Rev.Begin();
        }

        private void state_Click(object sender, RoutedEventArgs e)
        {
            if(live.CurrentState == MediaElementState.Playing)
            {
                live.Pause();
            }
            else
            {
                live.Play();
            }
        }
    }
}
