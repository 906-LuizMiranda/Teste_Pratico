using FluentValidation.Results;
using System.Text;

namespace TestePraticoDevPlenoUx.Application.Validations
{
    public static class BaseValidator
    {
        //public static string Validate()
        //{
        //    var modelValidator = new();

        //    var result = modelValidator.Validate();

        //    return ErrorStringBuilder(result);
        //}

        private static string ErrorStringBuilder(ValidationResult validationResult)
        {
            StringBuilder errorString = new StringBuilder();

            if (!validationResult.IsValid)
            {
                foreach(var error in validationResult.Errors)
                    errorString.Append("O campo " + error.PropertyName + " possui o seguinte erro: " + error.ErrorMessage + ".\n");
            }

            return errorString.Length > 0 ? errorString.ToString() : null;
        }
    }
}
