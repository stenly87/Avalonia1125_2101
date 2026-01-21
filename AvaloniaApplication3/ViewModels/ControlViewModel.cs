using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaApplication3.ViewModels;

public partial class ControlViewModel : ViewModelBase
{
    [ObservableProperty] 
    private int test = 100;
}