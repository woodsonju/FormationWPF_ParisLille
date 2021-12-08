using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WPF1Window.BindingTest.Model
{
    /// <summary>
    /// Convertisseur : 
    /// Il va traduire une valeur entre la "Source" et la "Destination"
    /// Il prend un chaine (string) en entrée puis retourne un booléen, et inversement
    /// </summary>
    public class YesNoToBooleanConverter : IValueConverter
    {

        /// <summary>
        /// La méthode Convert() récoit une chaine en entrée (le paramètre value), puis la convertit 
        /// en une valeur booléenne (true ou false)
        /// </summary>
        /// <param name="value">une chaine de caractère</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>un booléen (true, false, oui, non)</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString().ToLower())
            {
                case "yes":
                case "oui":
                    return true;
                case "no":
                case "non":
                    return false;
            }
            return false;
        }


        /// <summary>
        /// La méthode ConvertBack fait l'inverse
        /// Elle prend une valeur en entrée, qui est de type booléen et retourne le mot en anglais ("yes" ou "no")
        /// </summary>
        /// <param name="value">booléen : true ou false</param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns>chaine ("yes" ou "no")</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is bool)
            {
                if((bool)value)
                {
                    return "yes";
                }
            } else
            {
                return "no";
            }
            return "no";
        }
    }
}
