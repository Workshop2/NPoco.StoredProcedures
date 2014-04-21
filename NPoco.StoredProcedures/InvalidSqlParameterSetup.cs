using System;

namespace NPoco.StoredProcedures
{
    [Serializable]
    public class InvalidSqlParameterSetup : Exception
    {
        public InvalidSqlParameterSetup() { }

        public InvalidSqlParameterSetup(string errorMessage) : base(errorMessage) { }

        /// <summary>
        /// The constructor for creating an exception with an error message and a inner exception.
        /// </summary>
        /// <param name="errorMessage">The error message for the given exception.</param>
        /// <param name="innerException">Inner exception for a bubbling exception stacktrace.</param>
        public InvalidSqlParameterSetup(string errorMessage, Exception innerException) : base(errorMessage, innerException) { }
    }
}