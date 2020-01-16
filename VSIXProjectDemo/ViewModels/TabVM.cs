using System;
using System.Windows;

namespace VSIXProjectDemo.ViewModels
{
    public class TabVM : DependencyObject
    {
        public Uri SourceUri { get => (Uri)this.GetValue(SourceUriProperty); set => this.SetValue(SourceUriProperty, value); }
        public static readonly DependencyProperty SourceUriProperty = DependencyProperty.RegisterAttached(nameof(SourceUri), typeof(Uri), typeof(TabVM), new PropertyMetadata(null));
    }
}
