using System.Windows;

namespace KoalaVPN.Core
{
    public class Extensions
    {
        public static readonly DependencyProperty Icon =
        DependencyProperty.RegisterAttached("Icon",
        typeof(string), typeof(Extensions), new PropertyMetadata(default(string)));

        public static void SetIcon(UIElement element, string value)
        {
            element.SetValue(Icon, value);
        }

        public static string GetIcon(UIElement element)
        {
            return (string)element.GetValue(Icon);
        }
    }
}