using System;
using System.Windows;

namespace WPFRandomGenerator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private Random random = new Random();

    private void bExit_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void bGenerate_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            int minimum = Convert.ToInt32(numberMin.Text);
            int maximum = Convert.ToInt32(numberMax.Text);

            if (minimum < maximum)
                textNumber.Text = random.Next(minimum, maximum).ToString();
        }
        catch (Exception)
        {
            textNumber.Text = "Wrong values!";
        }
    }
}