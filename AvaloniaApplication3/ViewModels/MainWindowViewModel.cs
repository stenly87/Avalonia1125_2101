using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication3.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private string test;

    [ObservableProperty]
    private object testContent;

    [RelayCommand]
    public void OpenTestContent()
    {
        TestContent = new ControlViewModel();
    }
}