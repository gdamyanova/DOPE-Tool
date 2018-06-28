using Telerik.Windows.Controls.GanttView;
using Telerik.Windows.Rendering.Virtualization;

namespace DependencyObservationTool
{
    public class TimeLineDeadlineContainerSelector : DefaultTimeLineContainerSelector
    {
        protected static readonly ContainerTypeIdentifier TimeLineDeadlineContainerType = ContainerTypeIdentifier.FromType<TimeLineDeadlineContainer>();
        protected static readonly ContainerTypeIdentifier ProjectDeadlineContainerType = ContainerTypeIdentifier.FromType<ProjectDeadlineContainer>();

        public override ContainerTypeIdentifier GetContainerType(object item)
        {
            if (item is TimeLineDeadlineEventInfo)
            {
                return TimeLineDeadlineContainerType;
            }
            if (item is ProjectDeadlineEventInfo)
            {
                return ProjectDeadlineContainerType;
            }

            return base.GetContainerType(item);
        }
    }
}
