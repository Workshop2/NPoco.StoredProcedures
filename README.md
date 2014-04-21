NPoco.StoredProcedures
======================

Basic class for querying stored procedures



Example Usage
=============

''''c#
        public IEnumerable<MonthTotal> TotalForMonthInterval(ValueQueryResult queryResult, int startMonthId, int endMonthId)
        {
            IDatabase database = _databaseFactory.GetDatabase();

            var valueIdsParams = new Parameter("ValueIds", queryResult.GenerateCsv());
            var startMonthParam = new Parameter("StartMonthId", startMonthId);
            var endMonthParam = new Parameter("EndMonthId", endMonthId);

            IEnumerable<MonthTotal> result = database.QueryStoredProcedure<MonthTotal>("[Aggregation].[Total_Months]", valueIdsParams, startMonthParam, endMonthParam);
            return result;
        }
''''
