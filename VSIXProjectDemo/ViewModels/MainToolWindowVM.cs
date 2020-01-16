using System.Collections.ObjectModel;
using System.Windows;

namespace VSIXProjectDemo.ViewModels
{
    public class MainToolWindowVM : DependencyObject
    {
        public TabVM CurrentTab { get => (TabVM)this.GetValue(CurrentTabProperty); set => this.SetValue(CurrentTabProperty, value); }
        public static readonly DependencyProperty CurrentTabProperty = DependencyProperty.RegisterAttached(nameof(CurrentTab), typeof(TabVM), typeof(MainToolWindowVM), new PropertyMetadata(null));

        public ObservableCollection<TabVM> Tabs = new ObservableCollection<TabVM>();
    }
}
