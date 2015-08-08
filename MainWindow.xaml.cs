using System;
using System.Windows;
using System.Windows.Controls;

namespace FlightTimeCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = int.Parse(this.comboBox.Text);
                int num1 = int.Parse(this.comboBox1.Text);
                int num2 = num * 60 + num1;
                int num3 = int.Parse(this.comboBox3.Text);
                int num4 = int.Parse(this.comboBox2.Text);
                int num5 = num3 * 60 + num4;
                MyMessageBox myMessageBox = new MyMessageBox();
                if (num2 >= num5)
                {
                    num5 = num5 + 1440;
                    int num6 = num5 - num2;
                    int num7 = num6 / 60;
                    int num8 = num6 % 60;
                    if (num6 == 1)
                    {
                        myMessageBox.label.Content = string.Concat(num6, " minute");
                    }
                    else if (num6 < 60)
                    {
                        myMessageBox.label.Content = string.Concat(num6, " minutes");
                    }
                    else if (num6 == 60)
                    {
                        myMessageBox.label.Content = "1 hour";
                    }
                    else if (num6 == 61)
                    {
                        myMessageBox.label.Content = "1 hour and 1 minute";
                    }
                    else if ((num6 <= 60 ? false : num6 < 120))
                    {
                        myMessageBox.label.Content = string.Concat("1 hour and ", num8, " minutes");
                    }
                    else if (num6 >= 120)
                    {
                        if (num6 % 60 == 0)
                        {
                            myMessageBox.label.Content = string.Concat(num7, " hours");
                        }
                        else if (num6 % 60 != 1)
                        {
                            myMessageBox.label.Content = string.Concat(new object[] { num7, " hours and ", num8, " minutes" });
                        }
                        else
                        {
                            myMessageBox.label.Content = string.Concat(num7, " hours and 1 minute");
                        }
                    }
                }
                else
                {
                    int num9 = num5 - num2;
                    int num10 = num9 / 60;
                    int num11 = num9 % 60;
                    if (num9 == 1)
                    {
                        myMessageBox.label.Content = string.Concat(num9, " minute");
                    }
                    else if (num9 < 60)
                    {
                        myMessageBox.label.Content = string.Concat(num9, " minutes");
                    }
                    else if (num9 == 60)
                    {
                        myMessageBox.label.Content = "1 hour";
                    }
                    else if (num9 == 61)
                    {
                        myMessageBox.label.Content = "1 hour and 1 minute";
                    }
                    else if ((num9 <= 60 ? false : num9 < 120))
                    {
                        myMessageBox.label.Content = string.Concat("1 hour and ", num11, " minutes");
                    }
                    else if (num9 >= 120)
                    {
                        if (num9 % 60 == 0)
                        {
                            myMessageBox.label.Content = string.Concat(num10, " hours");
                        }
                        else if (num9 % 60 != 1)
                        {
                            myMessageBox.label.Content = string.Concat(new object[] { num10, " hours and ", num11, " minutes" });
                        }
                        else
                        {
                            myMessageBox.label.Content = string.Concat(num10, " hours and 1 minute");
                        }
                    }
                }
                myMessageBox.ShowDialog();
            }
            catch (Exception)
            {
                MyMessageBox myMessageBox1 = new MyMessageBox()
                {
                    Title = "Error"
                };
                myMessageBox1.label.Content = "Try again!";
                myMessageBox1.ShowDialog();
            }
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
