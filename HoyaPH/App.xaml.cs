﻿using HoyaPH.Test;

namespace HoyaPH;

public partial class App : Application
{
    public App(MainPage mainPage)
    {
        InitializeComponent();

        MainPage = new NavigationPage(mainPage);


    }
}
