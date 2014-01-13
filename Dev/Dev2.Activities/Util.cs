﻿using System;

// ReSharper disable CheckNamespace
namespace Unlimited.Applications.BusinessDesignStudio.Activities
{
    // ReSharper restore CheckNamespace
    public enum enDev2HTMLType { FORM, PAGETITLE, META, IMAGE, TEXT, MENU }

    public class Util
    {
        public static bool ValueIsNumber(string value)
        {
            double val = 0;
            return double.TryParse(value, out val);
        }

        public static bool ValueIsDate(string value)
        {
            DateTime date = DateTime.MinValue;
            return DateTime.TryParse(value, out date);
        }

        public static bool IsEmpty(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool Eq(string value, object comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) == DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) == double.Parse(comparisonValue.ToString());
                }
            }


            return string.Equals(value, comparisonValue.ToString(), StringComparison.CurrentCultureIgnoreCase);
        }

        public static bool NtEq(string value, object comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) != DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) != double.Parse(comparisonValue.ToString());
                }
            }

            return value != comparisonValue.ToString();
        }

        public static bool LsTh(string value, object comparisonValue)
        {

            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) < DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) < double.Parse(comparisonValue.ToString());
                }
            }

            return false;
        }

        public static bool LsThEq(string value, object comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) <= DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) <= double.Parse(comparisonValue.ToString());
                }
            }

            return false;
        }

        public static bool GrTh(string value, object comparisonValue)
        {

            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) > DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) > double.Parse(comparisonValue.ToString());
                }
            }


            return false;
        }


        public static bool GrThEq(string value, object comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValue == null)
            {
                return false;
            }

            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValue.ToString()))
                {
                    return DateTime.Parse(value) >= DateTime.Parse(comparisonValue.ToString());
                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValue.ToString()))
                {
                    return double.Parse(value) >= double.Parse(comparisonValue.ToString());
                }
            }

            return false;
        }

        public static bool Btw(string value, object comparisonValueStart, object comparisonValueEnd)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(comparisonValueStart == null)
            {
                return false;
            }

            if(comparisonValueEnd == null)
            {
                return false;
            }



            if(ValueIsDate(value))
            {
                if(ValueIsDate(comparisonValueStart.ToString()))
                {
                    if(ValueIsDate(comparisonValueEnd.ToString()))
                    {
                        return DateTime.Parse(value) >= DateTime.Parse(comparisonValueStart.ToString())
                            && DateTime.Parse(value) <= DateTime.Parse(comparisonValueEnd.ToString());
                    }

                }
            }

            if(ValueIsNumber(value))
            {
                if(ValueIsNumber(comparisonValueStart.ToString()))
                {
                    if(ValueIsNumber(comparisonValueEnd.ToString()))
                    {
                        return double.Parse(value) >= double.Parse(comparisonValueStart.ToString())
                            && double.Parse(value) <= double.Parse(comparisonValueEnd.ToString());
                    }

                }
            }

            return false;
        }

        public static bool Cnt(string value, string comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(string.IsNullOrEmpty(comparisonValue))
            {
                return false;
            }

            return value.Contains(comparisonValue);


        }

        public static bool StWt(string value, string comparisonValue)
        {
            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(string.IsNullOrEmpty(comparisonValue))
            {
                return false;
            }

            return value.StartsWith(comparisonValue);
        }

        public static bool EnWt(string value, string comparisonValue)
        {

            if(string.IsNullOrEmpty(value))
            {
                return false;
            }

            if(string.IsNullOrEmpty(comparisonValue))
            {
                return false;
            }

            return value.EndsWith(comparisonValue);

        }
    }
}
