using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;

namespace テストDB.Models
{
    [AttributeUsage(AttributeTargets.Property)]
    public class GreaterThanAttribute : ValidationAttribute
    {
        public string OtherProperty { get; private set; }

        public GreaterThanAttribute(string otherProperty)
        {
            OtherProperty = otherProperty;

            // ErrorMessageのデフォルト値、呼び出し時に書き換え可能
            ErrorMessage = "{0} must greater then {1}";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            // 比較対象
            PropertyInfo otherPInfo = validationContext.ObjectType.GetProperty(OtherProperty);
            object otherValue = otherPInfo.GetValue(validationContext.ObjectInstance, null);

            IComparable CValue;
            IComparable otherCValue;

            try
            {
                CValue = (IComparable)value;
                otherCValue = (IComparable)otherValue;
            }
            catch (Exception ex)
            {
                throw new Exception("比較できない値を比較しようとしている。" + ex.Message);
            }

            // GreaterThan だから > 0
            if (CValue.CompareTo(otherCValue) > 0)
            {
                return ValidationResult.Success;
            }

            string[] memberNames = new string[] { validationContext.MemberName };
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName), memberNames);
        }

        // 引数付きのエラーメッセージを文字列に加工する
        public override string FormatErrorMessage(string name)
        {
            // ErrorMessageString ： "{0} must greater then {1}"
            // name {0}の引数：自分自身のプロパティ名
            // OtherProperty {1}の引数：比較対象のプロパティ名
            return String.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, OtherProperty);
        }


    }

}
