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
        Project tasks = new Project();
        public ObservableCollection<Task> TasksNotStarted { get { return tasks.ListNotStarted; } }
        public ObservableCollection<Task> TasksInProgress { get { return tasks.ListInProgress; } }
        public ObservableCollection<Task> TasksCompleted { get { return tasks.ListCompleted; } }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void btAddTaskHandler(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbTask.Text) && !lbNotStarted.Items.Contains(tbTask.Text))
            {
                tasks.ListNotStarted.Add(new Task(tbTask.Text));
                tbTask.Clear();
            }
            UnselectAll();
        }

        private void btNotStartedHandler(object sender, RoutedEventArgs e)
        {
            if (lbInProgress.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbInProgress.SelectedItem, Task.State.notStarted);
            }
            else if (lbCompleted.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbCompleted.SelectedItem, Task.State.notStarted);
            }
        }

        private void btInProgressHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbNotStarted.SelectedItem, Task.State.inProgress);
            }
            else if (lbCompleted.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbCompleted.SelectedItem, Task.State.inProgress);
            }
        }

        private void btCompletedHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbNotStarted.SelectedItem, Task.State.completed);
            }
            else if (lbInProgress.SelectedItem != null)
            {
                tasks.ChangeTaskState((Task)lbInProgress.SelectedItem, Task.State.completed);
            }
        }
        
        void UnselectAll()
        {
            lbNotStarted.SelectedIndex = -1;
            lbInProgress.SelectedIndex = -1;
            lbCompleted.SelectedIndex = -1;
        }

        private void btRemoveTaskHandler(object sender, RoutedEventArgs e)
        {
            if (lbNotStarted.SelectedItem != null)
            {
                tasks.ListNotStarted.Remove((Task)lbNotStarted.SelectedItem);
            }
            else if (lbInProgress.SelectedItem != null)
            {
                tasks.ListInProgress.Remove((Task)lbInProgress.SelectedItem);
            }
            else if (lbCompleted.SelectedItem != null)
            {
                tasks.ListCompleted.Remove((Task)lbCompleted.SelectedItem);
            }
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
