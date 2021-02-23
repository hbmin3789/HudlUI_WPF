using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hud.Core.Controls
{
    public class HudButton : Button
    {
        public static DependencyProperty HOverBackgroundProperty = 
            DependencyProperty.Register("", typeof(Brush),
                                        typeof(HudButton), 
                                        new FrameworkPropertyMetadata(
                                            new SolidColorBrush(Color.FromRgb(0xb2, 0xeb, 0xf2)),
                                            FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

    }
}
