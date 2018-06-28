using System;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls.GanttView;

namespace DependencyObservationTool
{
    public class SoftwarePlanning: ObservableCollection<GanttDeadlineTask>
    {
        public SoftwarePlanning()
        {
            var scopeTaskChild1 = new GanttDeadlineTask(new DateTime(2018, 7, 5, 8, 0, 0), new DateTime(2018, 7, 8, 18, 0, 0), "[Adaco]Reach the maximum number of properties in a message") { Description = "Description: [Adaco]Reach the maximum number of properties in a message", GanttDeadLine = new DateTime(2018, 7, 11, 0, 0, 0) };

            var scopeTaskChild2 = new GanttDeadlineTask(new DateTime(2018, 7, 11, 8, 0, 0), new DateTime(2018, 7, 13, 18, 0, 0), "[R9]Extend a message to include an exotic property") { Description = "Description: [R9]Extend a message to include an exotic property", GanttDeadLine = new DateTime(2018, 7, 19, 0, 0, 0) };
            var scopeTaskChild3 = new GanttDeadlineTask(new DateTime(2018, 7, 5, 8, 0, 0), new DateTime(2018, 7, 13, 18, 0, 0), "[TS]Update a status and indulge yourselves in heavy test refactoring") { Description = "Description: [TS]Update a status and indulge yourselves in heavy test refactoring", GanttDeadLine = new DateTime(2018, 7, 19, 0, 0, 0) };
            var scopeTaskChild4 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 8, 0, 0), new DateTime(2018, 7, 22, 18, 0, 0), "[UI]Support the rest of the poor souls in E2E testing") { Description = "Description: [UI]Support the rest of the poor souls in E2E testing", GanttDeadLine = new DateTime(2018, 8, 2, 0, 0, 0) };

            scopeTaskChild2.Dependencies.Add(new Dependency { FromTask = scopeTaskChild1 });
            scopeTaskChild4.Dependencies.Add(new Dependency { FromTask = scopeTaskChild2 });
            scopeTaskChild4.Dependencies.Add(new Dependency { FromTask = scopeTaskChild3 });

            var scopeTask1 = new GanttDeadlineTask(new DateTime(2018, 7, 5, 0, 0, 0), new DateTime(2018, 7, 19, 0, 0, 0), "Sprint 139")
            {
                Children = { scopeTaskChild3, scopeTaskChild2,scopeTaskChild1 },
                Description = "Sprint 139"
            };
            this.Add(scopeTask1);

            
            var scopeTaskChild5 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 8, 0, 0), new DateTime(2018, 7, 22, 18, 0, 0), "[Adaco]It seems impossible, but you should add another parameter to this message") { Description = "Description: [Adaco]It seems impossible, but you should add another parameter to this message", GanttDeadLine = new DateTime(2018, 8, 2, 0, 0, 0) };

            var scopeTaskChild6 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 8, 0, 0), new DateTime(2018, 7, 26, 18, 0, 0), "[R9]Generate a message when the user thinks about it") { Description = "Description: [R9]Generate a message when the user thinks about it", GanttDeadLine = new DateTime(2018, 8, 2, 0, 0, 0) };
            var scopeTaskChild7 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 8, 0, 0), new DateTime(2018, 7, 29, 18, 0, 0), "[TS]Alter the work you just did last sprint") { Description = "Description: [TS]Alter the work you just did last sprint", GanttDeadLine = new DateTime(2018, 8, 2, 0, 0, 0) };
            var scopeTaskChild8 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 8, 0, 0), new DateTime(2018, 7, 24, 18, 0, 0), "[UI]Surpress more options for everyone, this is not a democracy") { Description = "Description: [UI]Surpress more options for everyone, this is not a democracy", GanttDeadLine = new DateTime(2018, 8, 2, 0, 0, 0) };

            var scopeTask2 = new GanttDeadlineTask(new DateTime(2018, 7, 19, 0, 0, 0), new DateTime(2018, 8, 2, 0, 0, 0), "Sprint 140")
            {
                Children = { scopeTaskChild4, scopeTaskChild5, scopeTaskChild6, scopeTaskChild7, scopeTaskChild8 },
                Description = "Sprint 140"
            };
            this.Add(scopeTask2);

            scopeTaskChild1.PropertyChanged += ScopeTaskChild1_PropertyChanged;
            void ScopeTaskChild1_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
            {
                var task = sender as GanttDeadlineTask;
                DateTime newEndTime = task.End;
                var delay = task.GanttDeadLine - newEndTime;
                scopeTaskChild2.End.Add(delay.Value);

            }
        }


    }
}
