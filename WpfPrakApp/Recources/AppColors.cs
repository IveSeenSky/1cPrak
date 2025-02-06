using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPrakApp.Recources
{
    public static class AppColors
    {
        public static Color PrimaryColor = Color.FromRgb(75, 179, 245); // Голубой
        public static Color SecondaryColor => Color.FromRgb(255, 152, 0); // Оранжевый
        public static Color AccentColor => Color.FromRgb(255, 64, 129); // Розовый
        public static Color BackgroundColor => Color.FromRgb(245, 245, 245); // Светло-серый
        public static Color TextColor => Color.FromRgb(50, 50, 50); // Темно-серый

        public static SolidColorBrush PrimaryBrush => new SolidColorBrush(PrimaryColor);
        public static SolidColorBrush SecondaryBrush => new SolidColorBrush(SecondaryColor);
        public static SolidColorBrush AccentBrush => new SolidColorBrush(AccentColor);
        public static SolidColorBrush BackgroundBrush => new SolidColorBrush(BackgroundColor);
        public static SolidColorBrush TextBrush => new SolidColorBrush(TextColor);
    }
}
