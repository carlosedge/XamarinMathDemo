using MobileMathKit.Models;
using MobileMathKit.ViewModels;
using MobileMathKit.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileMathKit.Views
{
    public partial class MathPage : ContentPage
    {

        public MathPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        int count = 0;
        void Button_Clicked(object sender, System.EventArgs e)
        {
            count++;
            //((Button)sender).Text = $"You clicked {count} times.";
            ResultEntry.Text = "Drag is "+ (0.5 * 1.225 * Convert.ToDouble(AreaEntry.Text) * Convert.ToDouble(CxEntry.Text) * Math.Pow(Convert.ToDouble(vEntry.Text),2)).ToString() + " Newtons.";
        }
    }
}