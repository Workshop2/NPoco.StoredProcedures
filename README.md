NPoco.StoredProcedures
======================

__Fully tested__ extension methods for querying Stored Procedures with NPoco.

__Install-Package NPoco.StoredProcedures__

[![Build status](https://ci.appveyor.com/api/projects/status/kbf7dgdaekxnd714)](https://ci.appveyor.com/project/Workshop2/npoco-storedprocedures)


Example Usage
=============

```c#
public IEnumerable<MonthTotal> TotalForMonthInterval(ValueQueryResult queryResult, int startMonthId, int endMonthId)
{
        IDatabase database = _databaseFactory.GetDatabase();

        var valueIdsParams = new Parameter("ValueIds", queryResult.GenerateCsv());
        var startMonthParam = new Parameter("StartMonthId", startMonthId);
        var endMonthParam = new Parameter("EndMonthId", endMonthId);

        IEnumerable<MonthTotal> result = database.QueryStoredProcedure<MonthTotal>("[Aggregation].[Total_Months]", valueIdsParams, startMonthParam, endMonthParam);
        return result;
}
```
