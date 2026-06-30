using System.Collections.ObjectModel;
using Dock.Model.Mvvm.Controls;
using EasyCpu.Assembler.Parsing;

namespace EasyCPU.vNext.ViewModels;

public partial class ErrorsViewModel : Tool
{
    public MainViewModel MainVm { get; }
    public ObservableCollection<CompilerError> Errors { get; } = new();

    public ErrorsViewModel(MainViewModel mainVm)
    {
        MainVm = mainVm;
    }
}
