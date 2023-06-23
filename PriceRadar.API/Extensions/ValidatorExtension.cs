using FluentValidation.Results;

namespace PriceRadar.API.Extensions
{
    public static class ValidatorExtension
    {
        public static string ConvertFailureToString(this List<ValidationFailure> failures)
        {
            if (!failures.Any())
            {
                return string.Empty;
            }

            var validationMessages = new List<string>();
            foreach (var failure in failures)
            {
                validationMessages.Add(failure.ErrorMessage);
            }
            validationMessages = validationMessages.Distinct().ToList();

            return validationMessages.Count == 1 ? validationMessages.FirstOrDefault() : string.Join(" ", validationMessages);
        }
    }
}
