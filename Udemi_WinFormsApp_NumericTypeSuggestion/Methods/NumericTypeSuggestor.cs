using System.Numerics;

namespace Udemi_WinFormsApp_NumericTypeSuggestion.Methods
{
    internal static class NumericTypeSuggestor
    {
        public static string SuggestNumericType (BigInteger minValue, BigInteger maxValue, bool integralOnly, bool precise)
        {
            string type="";

            if (integralOnly)
            {
                type = GetIntegralType(minValue, maxValue);
            }
            else
            {
                type = GetDecimalType(minValue, maxValue, precise);
            }
            return type;
        }

        private static string GetDecimalType(BigInteger minValue, BigInteger maxValue, bool precise)
        {
            string type = "";
            if (precise)
            {
                if (minValue >= (BigInteger)decimal.MinValue && maxValue <= (BigInteger)decimal.MaxValue)
                {
                    type = "decimal";
                }
            }
            else
            {
                if (minValue >= (BigInteger)float.MinValue && maxValue <= (BigInteger)float.MaxValue)
                {
                    type = "float";
                }
                else if (minValue >= (BigInteger)double.MinValue && maxValue <= (BigInteger)double.MaxValue)
                {
                    type = "double";
                }
            }
            return type;
        }

        private static string GetIntegralType(BigInteger minValue, BigInteger maxValue)
        {
            string type = "BigInteger";

            if (minValue>=byte.MinValue && maxValue <= byte.MaxValue)
            {
                type = "byte";
            }
            else if (minValue >= sbyte.MinValue && maxValue <= sbyte.MaxValue)
            {
                type = "sbyte";
            }
            else if (minValue >= ushort.MinValue && maxValue <= ushort.MaxValue)
            {
                type = "ushort";
            }
            else if (minValue >= short.MinValue && maxValue <= short.MaxValue)
            {
                type = "short";
            }
            else if (minValue >= uint.MinValue && maxValue <= uint.MaxValue)
            {
                type = "uint";
            }
            else if (minValue >= int.MinValue && maxValue <= int.MaxValue)
            {
                type = "int";
            }
            else if (minValue >= ulong.MinValue && maxValue <= ulong.MaxValue)
            {
                type = "ulong";
            }
            else if (minValue >= long.MinValue && maxValue <= long.MaxValue)
            {
                type = "long";
            };
            return type;
        }
    }
}
