﻿using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Notes.ViewModels;

internal class AboutViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "This app is writen in XAML and C# with .NET MAUI.";
    public ICommand ShowMoreInfoCommand { get; }

    public AboutViewModel()
    {
        ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
    }

    async Task ShowMoreInfo() =>
        await Launcher.Default.OpenAsync(MoreInfoUrl);
}
