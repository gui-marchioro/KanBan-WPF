using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void btAddTaskHandler(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTask.Text) && !lbNotStarted.Items.Contains(tbTask.Text))
            {
                lbNotStarted.Items.Add(tbTask.Text);
                tbTask.Clear();
            }
            UnselectAll();
        }

        private void btNotStartedHandler(object sender, RoutedEventArgs e)
        {
            if (lbInProgress.SelectedItem != null) 
                ChangeListBox(lbInProgress, lbNotStarted);
            else if (lbCompleted.SelectedItem != null) 
                ChangeListBox(lbCompleted, lbNotStarted);
        }

        private void btInProgressHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null) 
                ChangeListBox(lbNotStarted, lbInProgress);
            else if (lbCompleted.SelectedItem != null) 
                ChangeListBox(lbCompleted, lbInProgress);
        }

        private void btCompletedHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null) 
                ChangeListBox(lbNotStarted, lbCompleted);
            else if (lbInProgress.SelectedItem != null) 
                ChangeListBox(lbInProgress, lbCompleted);
        }
        void ChangeListBox(ListBox sender, ListBox receiver)
        {
            receiver.Items.Add(sender.SelectedItem);
            sender.Items.Remove(sender.SelectedItem);
            UnselectAll();
        }

        void UnselectAll()
        {
            lbNotStarted.SelectedIndex = -1;
            lbInProgress.SelectedIndex = -1;
            lbCompleted.SelectedIndex = -1;
        }

        private void btRemoveTaskHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null) lbNotStarted.Items.Remove(lbNotStarted.SelectedItem);
            else if (lbInProgress.SelectedItem != null) lbInProgress.Items.Remove(lbInProgress.SelectedItem);
            else if (lbCompleted.SelectedItem != null) lbCompleted.Items.Remove(lbCompleted.SelectedItem);
        }

        private void lbNotStartedUnselect(object sender, DependencyPropertyChangedEventArgs e)
        {
            lbInProgress.SelectedIndex = -1;
            lbCompleted.SelectedIndex = -1;
        }

        private void lbInProgressUnselect(object sender, DependencyPropertyChangedEventArgs e)
        {
            lbNotStarted.SelectedIndex = -1;
            lbCompleted.SelectedIndex = -1;
        }

        private void lbCompletedUnselect(object sender, DependencyPropertyChangedEventArgs e)
        {
            lbNotStarted.SelectedIndex = -1;
            lbInProgress.SelectedIndex = -1;
        }
    }
}
