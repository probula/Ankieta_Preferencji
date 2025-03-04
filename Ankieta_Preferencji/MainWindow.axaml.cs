using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ankieta_Preferencji;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void SubmitOne(object? sender, RoutedEventArgs e)
    {
        ShowTextBlock1.Text = inputName.Text;
        var comboBoxValue = (comboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "No selection";
        ShowTextBlock2.Text = comboBoxValue;
    }
}