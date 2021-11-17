namespace Hospital.WebApi.Service.Validations
{
    public static class BaseValidation
    {
        public static string RequiredField(string field) =>
            $"O campo {field} é obrigatório.";

        public static string FieldInvalidFormat(string field) =>
            $"O campo {field} não possui um formato válido.";
    }
}
