using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace stoves3.basInt.csharp.core.Utilities
{
    public static class EnumExtensions
    {
        public static T ParseWithDescriptions<T>(string stringToParse)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) { throw new ArgumentException("Invalid Enumeration Type"); }

            if (string.IsNullOrWhiteSpace(stringToParse)) return default(T);
            var descriptions = GetEnumDescriptions<T>();
            if (descriptions.ContainsKey(stringToParse)) return StringToEnum<T>(stringToParse);

            if (!descriptions.ContainsValue(stringToParse)) return (T)(object)0;

            var enumString = descriptions.First(d => d.Value == stringToParse).Key;

            return StringToEnum<T>(enumString);
        }

        public static Dictionary<string, string> GetEnumDescriptions<T>()
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) { throw new ArgumentException("Invalid Enumeration Type"); }
            var descriptions = new Dictionary<string, string>();

            var mis = typeof(T).GetMembers().Where(m => m.DeclaringType == typeof(T) && m.Name != "value__").ToList();
            mis.ForEach(mi =>
            {
                var descriptionAttributes = ((DescriptionAttribute[])mi.GetCustomAttributes(typeof(DescriptionAttribute), false)).ToList();
                if (descriptionAttributes.Count == 0)
                {
                    descriptions.Add(mi.Name, mi.Name);
                    return;
                }

                descriptions.Add(mi.Name, descriptionAttributes[0].Description);
            });

            return descriptions;
        }

        public static List<T> GetEnumEntries<T>()
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) { throw new ArgumentException("Invalid Enumeration Type"); }

            return typeof(T).GetMembers().Where(m => m.DeclaringType == typeof(T) && m.Name != "value__").Select(t => StringToEnum<T>(t.Name)).ToList();
        }

        public static List<string> GetEnumNames<T>()
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) { throw new ArgumentException("Invalid Enumeration Type"); }

            return typeof(T).GetMembers().Where(m => m.DeclaringType == typeof(T) && m.Name != "value__").Select(v => v.ToString()).ToList();
        }

        public static T StringToEnum<T>(string name)
            where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) { throw new ArgumentException("Invalid Enumeration Type"); }

            if (string.IsNullOrWhiteSpace(name)) return default(T);

            return (T)Enum.Parse(typeof(T), name);
        }

        public static string ToEnumString<T>(this T value)
            where T : struct, IConvertible
        {
            var description = value.ToDescription();
            return !string.IsNullOrWhiteSpace(description) ? description : value.ToString();
        }

        private static string ToDescription<T>(this T value)
        {
            var field = typeof(T).GetField(value.ToString());
            return field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                        .Cast<DescriptionAttribute>()
                        .Select(x => x.Description)
                        .FirstOrDefault();
        }
    }
}

