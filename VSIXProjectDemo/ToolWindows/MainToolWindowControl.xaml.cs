namespace VSIXProjectDemo.ToolWindows
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows;
    using Controls = System.Windows.Controls;
    using Input = System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainToolWindowControl.
    /// </summary>
    public partial class MainToolWindowControl : Controls.UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainToolWindowControl"/> class.
        /// </summary>
        public MainToolWindowControl()
        {
            this.InitializeComponent();
        }

        private void UriTextBox_KeyDown(object sender, Input.KeyEventArgs e)
        {
            if (e.Key != Input.Key.Enter) return;
            if (string.IsNullOrWhiteSpace(UriTextBox.Text)) return;

            this.DataContext = this.UriTextBox.Text;
        }
    }
}