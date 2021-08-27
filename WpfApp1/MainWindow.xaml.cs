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
using System.Collections.ObjectModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Tasks tListNotStarted = new Tasks();
        Tasks tListInProgress = new Tasks();
        Tasks tListCompleted = new Tasks();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public ObservableCollection<Task> TListNS { get { return tListNotStarted.TaskList; } }
        public ObservableCollection<Task> TListIP { get { return tListInProgress.TaskList; } }
        public ObservableCollection<Task> TListC { get { return tListCompleted.TaskList; } }

        private void btAddTaskHandler(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTask.Text) && !lbNotStarted.Items.Contains(tbTask.Text))
            {
                tListNotStarted.TaskList.Add(new Task(tbTask.Text));
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
            int index = sender.SelectedIndex;
            //System.Windows.MessageBox.Show("{0}", index.ToString()); //DEBUG
            if (receiver.Name == "lbNotStarted")
            {
                if (sender.Name == "lbInProgress")
                {
                    tListNotStarted.TaskList.Add(tListInProgress.TaskList.ElementAt<Task>(index));
                    tListInProgress.TaskList.Remove(tListInProgress.TaskList.ElementAt<Task>(index));
                }
                else if (sender.Name == "lbCompleted")
                {
                    tListNotStarted.TaskList.Add(tListCompleted.TaskList.ElementAt<Task>(index));
                    tListCompleted.TaskList.Remove(tListCompleted.TaskList.ElementAt<Task>(index));
                }
            }
            else if (receiver.Name == "lbInProgress")
            {               
                if (sender.Name == "lbNotStarted")
                {
                    tListInProgress.TaskList.Add(tListNotStarted.TaskList.ElementAt<Task>(index));
                    tListNotStarted.TaskList.Remove(tListNotStarted.TaskList.ElementAt<Task>(index));
                }
                else if (sender.Name == "lbCompleted")
                {
                    tListInProgress.TaskList.Add(tListCompleted.TaskList.ElementAt<Task>(index));
                    tListCompleted.TaskList.Remove(tListCompleted.TaskList.ElementAt<Task>(index));
                }
            }
            else if (receiver.Name == "lbCompleted")
            {
                if (sender.Name == "lbNotStarted")
                {
                    tListCompleted.TaskList.Add(tListNotStarted.TaskList.ElementAt<Task>(index));
                    tListNotStarted.TaskList.Remove(tListNotStarted.TaskList.ElementAt<Task>(index));
                }
                else if (sender.Name == "lbInProgress")
                {
                    tListCompleted.TaskList.Add(tListInProgress.TaskList.ElementAt<Task>(index));
                    tListInProgress.TaskList.Remove(tListInProgress.TaskList.ElementAt<Task>(index));
                }
            }
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
