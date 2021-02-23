using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace HudUI_WPF_Test.Controls
{
    public class HudScannerControl : Control
    {
        public static DependencyProperty IsAnimationEnabledProperty =
            DependencyProperty.Register("IsAnimationEnabled", 
                                        typeof(bool), 
                                        typeof(HudScannerControl), 
                                        new FrameworkPropertyMetadata(
                                            false, 
                                            FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        public bool IsAnimationEnabled
        {
            get => (bool)GetValue(IsAnimationEnabledProperty);
            set => SetValue(IsAnimationEnabledProperty, value);
        }
    }
}
