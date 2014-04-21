using System.Collections.Generic;

namespace NPoco.StoredProcedures
{
    public static class DatabaseExtensions
    {
        public static IEnumerable<T> QueryStoredProcedure<T>(this IDatabase database, string procedureName, params Parameter[] parameters)
        {
            var procBuilder = new StoredProcedureBuilder(procedureName);
            procBuilder.AddParameters(parameters);
            return database.Query<T>(procBuilder.Build());
        }

        public static T SingleStoredProcedure<T>(this IDatabase database, string procedureName, params Parameter[] parameters)
        {
            var procBuilder = new StoredProcedureBuilder(procedureName);
            procBuilder.AddParameters(parameters);
            return database.SingleOrDefault<T>(procBuilder.Build());
        }

        public static void ExecuteStoredProcedure(this IDatabase database, string procedureName, params Parameter[] parameters)
        {
            var procBuilder = new StoredProcedureBuilder(procedureName);
            procBuilder.AddParameters(parameters);
            database.Execute(procBuilder.Build());
        }
    }
}