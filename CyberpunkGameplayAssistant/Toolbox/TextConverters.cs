using System;
using System.Globalization;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class AllyEnemy : ConverterMarkupExtension<AllyEnemy>
    {
        public AllyEnemy()
        {

        }
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool.Parse(value.ToString()!)) ? "Ally" : "Enemy";
        }
    }
}
