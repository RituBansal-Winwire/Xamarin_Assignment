using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        string[] assignment = { "This is First assignment", "This is Second assignment", "This is Third assignment", "This is fourth assignment" };
        int i = 0;
        public QuotesPage()
        {
            InitializeComponent();
            if (Device.Android == TargetPlatform.Android.ToString())
                Padding = new Thickness(0, 60, 0, 0);
            else if (Device.iOS == TargetPlatform.iOS.ToString())
                Padding = new Thickness(0, 40, 0, 0);

        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = ((int)e.NewValue);
            Changefont.FontSize = value;
            displayLabel.Text = String.Format("Font Size: {0}", value);
        }

        private void ChangeText(object sender, EventArgs e)
        {
            Changefont.Text = assignment[i];
            i++;
            if (i == assignment.Length)
            {
                i = 0;
            }

        }
    }
}