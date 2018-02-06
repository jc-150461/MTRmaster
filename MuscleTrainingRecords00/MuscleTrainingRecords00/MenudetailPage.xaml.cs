﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenudetaliPage : ContentPage
    {
        string t;

        //今日の日付
        static  DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        string date = now.ToString("yyyy/MM/dd");
        public MenudetaliPage(string m, string d, string i)//String m
        {
            InitializeComponent();

            Transition.Text = m.Trim(); //メニュー名

            Load.Text = l; //負荷度



            Description.Text = d; //やり方

            image.Source = ImageSource.FromStream(() => GetType().GetTypeInfo().Assembly.GetManifestResourceStream(i));

            t = m;

        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            ReModel.name = t;
            RecordsModel.InsertRe(1,t,0,0,0,date);

            Navigation.PushAsync(new RecordListPage());

        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}