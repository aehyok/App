﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aehyok.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("测试弹框", "Hello My First Message", "取消");
            //Navigation.PushModalAsync(new CarouselPage.CarouselPageTest());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new MasterDetailPage.MasterDetailPageTest());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new TabbedPage.TabbedPageTest());
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new StackLayoutDemo());
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new AbsoluteLayoutDemo());
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new RelativeLayoutDemo());
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new GridDemo());
        }
    }
}
