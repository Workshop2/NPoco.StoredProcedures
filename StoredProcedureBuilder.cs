using System.Collections.Generic;

namespace NPoco.StoredProcedures
{
    public class StoredProcedureBuilder
    {
        private readonly Sql _sql;
        private const string PROCEDURE_FORMAT = "EXEC {0}";
        private bool _parameterAdded;

        public StoredProcedureBuilder(Sql sql, string procedureName)
        {
            string initalSql = string.Format(PROCEDURE_FORMAT, procedureName);
            _sql = sql.Append(initalSql);
        }

        public StoredProcedureBuilder(string procedureName)
        {
            string initalSql = string.Format(PROCEDURE_FORMAT, procedureName);
            _sql = new Sql(initalSql);
        }

        public void AddParameter(Parameter parameter)
        {
            string parameterSql = string.Concat("@@", parameter.Name, " = @0");

            if (_parameterAdded)
                parameterSql = string.Concat(", ", parameterSql);

            _sql.Append(parameterSql, parameter.Value);
            _parameterAdded = true;
        }

        public void AddParameters(IEnumerable<Parameter> parameters)
        {
            foreach (Parameter parameter in parameters)
            {
                AddParameter(parameter);
            }
        }

        public Sql Build()
        {
            _sql.Append(";");
            return _sql;
        }
    }
}