using System.Windows;
using System.Windows.Controls;

namespace DiabetesPrediction;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

  

    private void TextBox_LostFocus(object sender, RoutedEventArgs e)
    {
        var txtBox = (TextBox)e.Source;
        var isValid= double.TryParse(txtBox.Text, out _);
        if (!isValid) txtBox.Text = 0.ToString();
    }
}
