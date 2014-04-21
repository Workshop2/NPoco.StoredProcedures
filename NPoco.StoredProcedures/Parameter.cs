namespace NPoco.StoredProcedures
{
    public class Parameter
    {
        public readonly string Name;
        public readonly object Value;

        public Parameter(string name, object value)
        {
            name = (name ?? string.Empty).Trim();

            if (string.IsNullOrEmpty(name))
                throw new InvalidSqlParameterSetup("Parameter name can not be null or empty");

            if (name.StartsWith("@"))
                throw new InvalidSqlParameterSetup("Name should not start with an '@' symbol");

            Name = name;
            Value = value;
        }
    }
}