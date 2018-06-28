using System.Windows.Controls;
using Telerik.Windows.Rendering;

namespace DependencyObservationTool
{
    public class TimeRulerAlternatingContainer : Control, IDataContainer
    {
        public TimeRulerAlternatingContainer()
        {
            this.DefaultStyleKey = typeof(TimeRulerAlternatingContainer);
        }

        public object DataItem { get; set; }
    }
}
