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

namespace DependencyObservationTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;
            this.DataContext = new GanttDeadlineViewModel();
        }

        private void gantt_TaskEdited(object sender, Telerik.Windows.Controls.GanttView.TaskEditedEventArgs e)
        {
            this.RefreshTimeRuler();
        }
        private void RefreshTimeRuler()
        {
            var viewModel = this.DataContext as GanttDeadlineViewModel;
            var tempBehavior = viewModel.TimeRulerDeadlineBehavior;
            viewModel.TimeRulerDeadlineBehavior = null;
            viewModel.TimeRulerDeadlineBehavior = tempBehavior;
        }
    }
}
