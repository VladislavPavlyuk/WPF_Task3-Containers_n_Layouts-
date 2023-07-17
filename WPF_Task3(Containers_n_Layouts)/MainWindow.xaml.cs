using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Task3_Containers_n_Layouts_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double stringToDouble(string s)
        {
            char systemSeparator = Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator[0];

            double result = 0;

            try
                {
                    if ((s != null)&&(s!=""))
                  
                            if (!s.Contains(","))
                                result = double.Parse(s, CultureInfo.InvariantCulture);
                            else
                                result = Convert.ToDouble(s.Replace(".", systemSeparator.ToString()).Replace(",", systemSeparator.ToString()));
                }
            catch (Exception e)
                {
                    try
                    {
                        result = Convert.ToDouble(s);
                    }
                    catch
                    {
                        try
                        {
                            result = Convert.ToDouble(s.Replace(",", ";").Replace(".", ",").Replace(";", "."));
                        }
                        catch
                        {
                            throw new Exception("Wrong string-to-double format", e);
                        }
                    }
                }

            return result;
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = (
                stringToDouble(a11.Text) *
                stringToDouble(a22.Text) *
                stringToDouble(a33.Text) -
                stringToDouble(a11.Text) *
                stringToDouble(a23.Text) *
                stringToDouble(a32.Text) -
                stringToDouble(a12.Text) *
                stringToDouble(a21.Text) *
                stringToDouble(a33.Text) +
                stringToDouble(a12.Text) *
                stringToDouble(a23.Text) *
                stringToDouble(a31.Text) +
                stringToDouble(a13.Text) *
                stringToDouble(a21.Text) *
                stringToDouble(a32.Text) -
                stringToDouble(a13.Text) *
                stringToDouble(a22.Text) *
                stringToDouble(a31.Text)
                ).ToString();
        }

    }
}