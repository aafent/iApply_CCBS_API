namespace CCBS.Models
{
    internal static class Extensions
    {
        public static T ConvertStringToNumber<T>(this string input) where T : struct
        {
            if (typeof(T) == typeof(int))
            {
                return (T)(object)Convert.ToInt32(input);
            }
            else if (typeof(T) == typeof(double))
            {
                return (T)(object)Convert.ToDouble(input);
            }
            else if (typeof(T) == typeof(decimal))
            {
                return (T)(object)Convert.ToDecimal(input);
            }
            else if (typeof(T) == typeof(long))
            {
                return (T)(object)Convert.ToInt64(input);
            }
            else if (typeof(T) == typeof(float))
            {
                return (T)(object)Convert.ToSingle(input);
            }
            else if (typeof(T) == typeof(short))
            {
                return (T)(object)Convert.ToInt16(input);
            }
            else if (typeof(T) == typeof(byte))
            {
                return (T)(object)Convert.ToByte(input);
            }
            else
            {
                throw new InvalidOperationException($"Conversion to {typeof(T).Name} is not supported.");
            }
        }
    }
}
