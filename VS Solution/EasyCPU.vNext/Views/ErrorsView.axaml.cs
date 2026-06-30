#nullable enable
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using EasyCpu.Assembler.Parsing;
using EasyCPU.vNext.ViewModels;

namespace EasyCPU.vNext.Views;

public partial class ErrorsView : UserControl
{
    public ErrorsView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    private void OnErrorDoubleTapped(object? sender, TappedEventArgs e)
    {
        if (DataContext is not ErrorsViewModel vm) return;
        if (sender is not ListBox listBox) return;
        if (listBox.SelectedItem is not CompilerError err) return;
        vm.MainVm.NavigateToError(err);
    }
}
