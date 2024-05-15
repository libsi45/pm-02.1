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

namespace задание_3_часа
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeComponent();

            Rectangle myRectangle = new Rectangle();
            myRectangle.Width = 200;
            myRectangle.Height = 100;
            myRectangle.Fill = Brushes.Blue;
            myRectangle.Stroke = Brushes.Black;
            myRectangle.StrokeThickness = 2;

         
            MainGrid.Children.Add(myRectangle);
        }
        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            string phoneNumber = phoneTextBox.Text;
            MessageBox.Show("Phone number: " + phoneNumber);
        }

        private void AddPhoneNumberButton_Click(object sender, RoutedEventArgs e)
        {
            Label phoneNumberLabel = new Label();
            phoneNumberLabel.Content = "Phone Number:";
            phoneNumberLabel.Margin = new Thickness(10);

            TextBox phoneNumberTextBox = new TextBox();
            phoneNumberTextBox.Name = "PhoneNumberTextBox";
            phoneNumberTextBox.Margin = new Thickness(10);

            StackPanel phoneNumberStackPanel = new StackPanel();
            phoneNumberStackPanel.Orientation = Orientation.Horizontal;
            phoneNumberStackPanel.Children.Add(phoneNumberLabel);
            phoneNumberStackPanel.Children.Add(phoneNumberTextBox);

            PhoneNumberStackPanel.Children.Add(phoneNumberStackPanel);
        }

        private void SaveContactButton_Click(object sender, RoutedEventArgs e)
        {
            // Save contact with phone number data
            foreach (StackPanel stackPanel in PhoneNumberStackPanel.Children)
            {
                TextBox phoneNumberTextBox = (TextBox)stackPanel.Children[1];
                string phoneNumber = phoneNumberTextBox.Text;
                // Save phone number data

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TabControl tabControl = ((TabControl)((TabItem)this.Parent).Parent);

            
            foreach (TabItem item in tabControl.Items)
            {
                if (item.Name == "tabItemWindow1")
                {
                    tabControl.SelectedItem = item;
                    break;
                }
            }
        }
    }
}