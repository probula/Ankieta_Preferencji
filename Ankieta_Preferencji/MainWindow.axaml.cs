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

    private void SubmitTwo(object? sender, RoutedEventArgs e)
    {
        var checkBoxValue1 = Option1.IsChecked == true ? "Checked" : "Unchecked";
        var checkBoxValue2 = Option2.IsChecked == true ? "Checked" : "Unchecked";
        var checkBoxValue3 = Option3.IsChecked == true ? "Checked" : "Unchecked";
        
        ShowTextBlock3.Text = checkBoxValue1;
        ShowTextBlock4.Text = checkBoxValue2;
        ShowTextBlock5.Text = checkBoxValue3;
    }
}