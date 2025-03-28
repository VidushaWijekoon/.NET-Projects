using System.Text.RegularExpressions;

namespace FeildValidatorAPI
{
    public delegate bool RequiredValiDel(string fieldVal);
    public delegate bool StringLengValiDel(string fieldVal, int min, int max);
    public delegate bool DateValiDel(string fieldVal, out DateTime valiDateTime);
    public delegate bool PatternMatchValDel(string fieldVal, string pattern);
    public delegate bool CompareFieldValiDel(string fieldVal, string fieldValCompare);

    public class CommonFieldValidatorFunctions
    {
        private static RequiredValiDel? _requiredValiDel = null;
        private static StringLengValiDel? _stringLengValiDel = null;
        private static DateValiDel? _dateValiDel = null;
        private static PatternMatchValDel? _patternMatchValDel = null;
        private static CompareFieldValiDel? _compareFieldValiDel = null;

        private static bool RequiredValiDel(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal))
                return true;
            return false;
        }

        private static bool StringFieldLengthVaild(string fieldVal, int min, int max)
        {
            if (fieldVal.Length >= min && fieldVal.Length <= max)
                return true;
            return false;
        }

        private static bool DateFieldValid(string dateTime, out DateTime validDateTime)
        {
            if (DateTime.TryParse(dateTime, out validDateTime))
                return true;
            return false;
        }

        private static bool FieldPatternValid(string fieldVal, string regularExpressionPattern)
        {
            Regex regex = new Regex(regularExpressionPattern);

            if (regex.IsMatch(fieldVal))
                return true;
            return false;
        }

        private static bool FieldComparisonValid(string field1, string field2)
        {
            if (field1.Equals(field2))
                return true;
            return false;
        }
    }
}




