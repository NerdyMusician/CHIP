using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace CyberpunkGameplayAssistant.Toolbox
{
    public class CollapsedIfTrue : ConverterMarkupExtension<CollapsedIfTrue>
    {
        public CollapsedIfTrue()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool visibility = (bool)value;
            return !visibility ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Visible);
        }

    }
    public class CollapsedIfFalse : ConverterMarkupExtension<CollapsedIfFalse>
    {
        public CollapsedIfFalse()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool visibility = (bool)value;
            return !visibility ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class VisibleIfMatch : ConverterMarkupExtension<VisibleIfMatch>
    {
        public VisibleIfMatch()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (value.ToString() == parameter.ToString()) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class VisibleIfEqual : ConverterMarkupExtension<VisibleIfEqual>
    {
        public VisibleIfEqual()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (int.TryParse(value.ToString(), out int intVal) == false) { return Visibility.Collapsed; }
            if (int.TryParse(parameter.ToString(), out int threshold) == false) { return Visibility.Collapsed; }
            return (intVal == threshold) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class VisibleIfEqualOrMore : ConverterMarkupExtension<VisibleIfEqualOrMore>
    {
        public VisibleIfEqualOrMore()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (int.TryParse(value.ToString(), out int intVal) == false) { return Visibility.Collapsed; }
            if (int.TryParse(parameter.ToString(), out int threshold) == false) { return Visibility.Collapsed; }
            return (intVal >= threshold) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class VisibleIfEqualOrLess : ConverterMarkupExtension<VisibleIfEqualOrLess>
    {
        public VisibleIfEqualOrLess()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (int.TryParse(value.ToString(), out int intVal) == false) { return Visibility.Collapsed; }
            if (int.TryParse(parameter.ToString(), out int threshold) == false) { return Visibility.Collapsed; }
            return (intVal <= threshold) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class VisibleIfEqualOrLessButNotZero : ConverterMarkupExtension<VisibleIfEqualOrLessButNotZero>
    {
        public VisibleIfEqualOrLessButNotZero()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (int.TryParse(value.ToString(), out int intVal) == false) { return Visibility.Collapsed; }
            if (int.TryParse(parameter.ToString(), out int threshold) == false) { return Visibility.Collapsed; }
            return (intVal <= threshold && intVal > 0) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }

    }
    public class CollapsedIfNull : ConverterMarkupExtension<CollapsedIfNull>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (value == null) ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }
    }
    public class CollapsedIfNotNull : ConverterMarkupExtension<CollapsedIfNotNull>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (value == null) ? Visibility.Visible : Visibility.Collapsed;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Visible);
        }
    }
    public class FalseIfZero : ConverterMarkupExtension<FalseIfZero>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return !((int)value == 0);
        }
    }
    public class CollapsedIfZero : ConverterMarkupExtension<CollapsedIfZero>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return ((int)value <= 0) ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }
    }
    public class CollapsedIfNullOrEmpty : ConverterMarkupExtension<CollapsedIfNullOrEmpty>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (value == null || value.ToString() == "") ? Visibility.Collapsed : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Collapsed);
        }
    }
    
    public class HiddenIfNull : ConverterMarkupExtension<HiddenIfNull>
    {
        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return (value == null) ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Hidden);
        }
    }
    public class MultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Clone();
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class ModSymbol : ConverterMarkupExtension<ModSymbol>
    {
        public ModSymbol()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((int)value >= 0)
            {
                return "+";
            }
            else
            {
                return "";
            }
        }
    }
    public class ColorBasedOnAlertType : ConverterMarkupExtension<ColorBasedOnAlertType>
    {
        public ColorBasedOnAlertType()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) { return null; }
            return value.ToString() switch
            {
                AppData.AlertError => Brushes.DarkRed,
                _ => Brushes.DarkSlateBlue
            };
        }
    }
    public class AllyEnemyColor : ConverterMarkupExtension<AllyEnemyColor>
    {
        public AllyEnemyColor()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.Parse(value.ToString()!) ? Brushes.DarkGreen : Brushes.DarkRed;
        }
    }
    public class ValidationFontColor : ConverterMarkupExtension<ValidationFontColor>
    {
        public ValidationFontColor()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return bool.Parse(value.ToString()!) ? Brushes.White : Brushes.DimGray;
        }

    }
    public class HiddenIfFalse : ConverterMarkupExtension<HiddenIfFalse>
    {
        public HiddenIfFalse()
        {
        }

        public override object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool visibility = (bool)value;
            return !visibility ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            Visibility visibility = (Visibility)value;
            return (visibility != Visibility.Hidden);
        }

    }
    public class ReverseBoolean : ConverterMarkupExtension<ReverseBoolean>
    {
        public ReverseBoolean()
        {

        }

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((bool)value);
        }

    }
    public abstract class ConverterMarkupExtension<T> : MarkupExtension, IValueConverter, IMultiValueConverter
        where T : class, new()
    {

        private static T _converter = null;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (_converter == null)
            {
                _converter = new T();
            }

            return _converter;
        }

        public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public virtual object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public virtual object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

}