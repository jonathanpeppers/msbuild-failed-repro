﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent ();

			MainPage = new MainPage ();
		}
	}
}
