﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MuscleTrainingRecords00;
using System.Windows.Input;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecordListPage : ContentPage
    {
        private string test;

        public RecordListPage()
        {
            InitializeComponent();
           
        }

        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
            
        }

        /*private void Records1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            string i = test;
           Navigation.PushAsync(new RecordPage(i));
        }*/

        /* private void insertButtonClicked(object sender, EventArgs e)
         {
             Navigation.PushAsync(new RecordPage());
         }
         */

        /* private async void OnRefreshing(object sender , EventArgs e)
         {
             await Task.Delay(1000);
             list.IsRefreshing = false;
             InitializeComponent();
         }
         */

    }
}