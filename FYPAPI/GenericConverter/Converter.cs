using System;
using System.Linq;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace FYPAPI.GenericConverter
{
    public class Converter<T> : TypeConverter where T : new()
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (typeof(string) == sourceType)
                return true;
            return base.CanConvertFrom(context, sourceType);
        }
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string strVal = value as string;
            if (string.IsNullOrEmpty(strVal))
                return new T();

            T converTo = new T();

            string[] filters = strVal.Split(';');

            foreach (var filter in filters)
            {
                string[] filterSplit = filter.Split(':');
                if (filterSplit.Length == 2)
                {
                    string key = filterSplit[0];
                    string val = filterSplit[1];
                    SetPropertyValue(converTo, key, val);
                }
            }
            return converTo;
        }

        private void SetPropertyValue(T converTo, string key, string val)
        {
            Type t = typeof(T);
            PropertyInfo[] props = t.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            PropertyInfo prop = props.Where(p => p.Name.Equals(key, StringComparison.CurrentCultureIgnoreCase) == true && p.CanWrite).FirstOrDefault();
            if (prop is null) return;
            prop.SetValue(converTo, TypeDescriptor.GetConverter(prop.PropertyType).ConvertFrom(val));
        }
    }
}