using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using NPoco.Expressions;

namespace NPoco.StoredProcedures.Tests.Unit.Stubs
{
    public class DatabaseStub : IDatabase
    {
        public Sql ExecuteSql { get; private set; }
        public int Execute(Sql sql)
        {
            ExecuteSql = sql;
            return 0;
        }

        public Sql QuerySql { get; private set; }
        public IEnumerable<object> QueryResult { get; set; }
        public IEnumerable<T> Query<T>(Sql sql)
        {
            QuerySql = sql;

            var result = new List<T>();

            if (QueryResult != null)
            {
                result.AddRange(QueryResult.OfType<T>());
            }

            return result;
        }

        public Sql SingleSql { get; private set; }
        public object SingleResult { get; set; }
        public T SingleOrDefault<T>(Sql sql)
        {
            SingleSql = sql;

            T result = default(T);

            if (SingleResult != null)
            {
                result = (T)SingleResult;
            }

            return result;
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////NOT IMPLEMENTED///////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OpenSharedConnection()
        {
            throw new NotImplementedException();
        }

        public void CloseSharedConnection()
        {
            throw new NotImplementedException();
        }

        public void BuildPageQueries<T>(long skip, long take, string sql, ref object[] args, out string sqlCount, out string sqlPage)
        {
            throw new NotImplementedException();
        }

        public int Execute(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T ExecuteScalar<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> Fetch<T>()
        {
            throw new NotImplementedException();
        }

        public List<T> Fetch<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T> Fetch<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> Fetch<T>(long page, long itemsPerPage, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T> Fetch<T>(long page, long itemsPerPage, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> FetchBy<T>(Func<SqlExpression<T>, SqlExpression<T>> expression)
        {
            throw new NotImplementedException();
        }

        public List<T> FetchWhere<T>(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Page<T> Page<T>(long page, long itemsPerPage, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Page<T> Page<T>(long page, long itemsPerPage, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T> SkipTake<T>(long skip, long take, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T> SkipTake<T>(long skip, long take, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2, T3>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2, T3, T4>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2, T3>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2, T3, T4>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TRet> Query<TRet>(Type[] types, Delegate cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2, T3>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public List<T1> Fetch<T1, T2, T3, T4>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2, T3>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T1> Query<T1, T2, T3, T4>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T SingleById<T>(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefaultById<T>(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefault<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T SingleInto<T>(T instance, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefaultInto<T>(T instance, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T First<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T FirstInto<T>(T instance, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefaultInto<T>(T instance, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public T Single<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public T SingleInto<T>(T instance, Sql sql)
        {
            throw new NotImplementedException();
        }

        public T SingleOrDefaultInto<T>(T instance, Sql sql)
        {
            throw new NotImplementedException();
        }

        public T First<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public T FirstInto<T>(T instance, Sql sql)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefaultInto<T>(T instance, Sql sql)
        {
            throw new NotImplementedException();
        }

        public Dictionary<TKey, TValue> Dictionary<TKey, TValue>(Sql Sql)
        {
            throw new NotImplementedException();
        }

        public Dictionary<TKey, TValue> Dictionary<TKey, TValue>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool Exists<T>(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, TRet>(Func<List<T1>, List<T2>, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, T3, TRet>(Func<List<T1>, List<T2>, List<T3>, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, T3, T4, TRet>(Func<List<T1>, List<T2>, List<T3>, List<T4>, TRet> cb, string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, TRet>(Func<List<T1>, List<T2>, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, T3, TRet>(Func<List<T1>, List<T2>, List<T3>, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public TRet FetchMultiple<T1, T2, T3, T4, TRet>(Func<List<T1>, List<T2>, List<T3>, List<T4>, TRet> cb, Sql sql)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>> FetchMultiple<T1, T2>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>, List<T3>> FetchMultiple<T1, T2, T3>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>, List<T3>, List<T4>> FetchMultiple<T1, T2, T3, T4>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>> FetchMultiple<T1, T2>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>, List<T3>> FetchMultiple<T1, T2, T3>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public Tuple<List<T1>, List<T2>, List<T3>, List<T4>> FetchMultiple<T1, T2, T3, T4>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public int OneTimeCommandTimeout { get; set; }
        public IMapper Mapper { get; set; }
        public Func<Type, PocoData> PocoDataFactory { get; set; }
        public DatabaseType DatabaseType { get; private set; }
        public string ConnectionString { get; private set; }
        public IDataParameter CreateParameter()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction()
        {
            throw new NotImplementedException();
        }

        public Transaction GetTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public void SetTransaction(IDbTransaction tran)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction(IsolationLevel isolationLevel)
        {
            throw new NotImplementedException();
        }

        public void AbortTransaction()
        {
            throw new NotImplementedException();
        }

        public void CompleteTransaction()
        {
            throw new NotImplementedException();
        }

        public object Insert<T>(string tableName, string primaryKeyName, bool autoIncrement, T poco)
        {
            throw new NotImplementedException();
        }

        public object Insert<T>(string tableName, string primaryKeyName, T poco)
        {
            throw new NotImplementedException();
        }

        public object Insert<T>(T poco)
        {
            throw new NotImplementedException();
        }

        public void InsertBulk<T>(IEnumerable<T> pocos)
        {
            throw new NotImplementedException();
        }

        public int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue)
        {
            throw new NotImplementedException();
        }

        public int Update(string tableName, string primaryKeyName, object poco)
        {
            throw new NotImplementedException();
        }

        public int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue, IEnumerable<string> columns)
        {
            throw new NotImplementedException();
        }

        public int Update(string tableName, string primaryKeyName, object poco, IEnumerable<string> columns)
        {
            throw new NotImplementedException();
        }

        public int Update(object poco, IEnumerable<string> columns)
        {
            throw new NotImplementedException();
        }

        public int Update(object poco, object primaryKeyValue, IEnumerable<string> columns)
        {
            throw new NotImplementedException();
        }

        public int Update(object poco)
        {
            throw new NotImplementedException();
        }

        public int Update(object poco, object primaryKeyValue)
        {
            throw new NotImplementedException();
        }

        public int Update<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public int Update<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public int Delete(string tableName, string primaryKeyName, object poco)
        {
            throw new NotImplementedException();
        }

        public int Delete(string tableName, string primaryKeyName, object poco, object primaryKeyValue)
        {
            throw new NotImplementedException();
        }

        public int Delete(object poco)
        {
            throw new NotImplementedException();
        }

        public int Delete<T>(string sql, params object[] args)
        {
            throw new NotImplementedException();
        }

        public int Delete<T>(Sql sql)
        {
            throw new NotImplementedException();
        }

        public int Delete<T>(object pocoOrPrimaryKey)
        {
            throw new NotImplementedException();
        }

        public void Save<T>(object poco)
        {
            throw new NotImplementedException();
        }

        public bool IsNew<T>(object poco)
        {
            throw new NotImplementedException();
        }

        public IDbConnection Connection { get; private set; }
        public IDbTransaction Transaction { get; private set; }
    }
}