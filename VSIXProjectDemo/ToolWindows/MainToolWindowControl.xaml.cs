namespace VSIXProjectDemo.ToolWindows
{
    using System;
    using VSIXProjectDemo.ViewModels;
    using Controls = System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MainToolWindowControl.
    /// </summary>
    public partial class MainToolWindowControl : Controls.UserControl
    {
        public MainToolWindowVM ViewModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainToolWindowControl"/> class.
        /// </summary>
        public MainToolWindowControl()
        {
            this.InitializeComponent();

            this.ViewModel = new MainToolWindowVM
            {
                CurrentTab = new TabVM() { SourceUri = new Uri("https://www.zhihu.com") }
            };
            this.DataContext = this.ViewModel;
        }
    }
}