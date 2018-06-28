using System.Windows.Controls;
using Telerik.Windows.Rendering;

namespace DependencyObservationTool
{
    public class ProjectDeadlineContainer: Control, IDataContainer
    {
        public ProjectDeadlineContainer()
        {
            this.DefaultStyleKey = typeof(ProjectDeadlineContainer);
        }
        public object DataItem { get; set; }
    }
}
