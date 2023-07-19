using System.Globalization;

namespace System 
    // Quando criar um extension method para uma determinada classe ou struct, coloque a classe que contém o extension method no mesmo namespace
    // do tipo que vc está extendendo. Nesse caso, foi criado um extension method de uma classe (DateTime) que pertence ao namespace 'System'
{
    internal static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj) 
        {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24) return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            else return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
        }
    }
}
