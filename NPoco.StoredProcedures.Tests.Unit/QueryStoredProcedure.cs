using System.Linq;
using NPoco.StoredProcedures.Tests.Unit.Stubs;
using NUnit.Framework;
using Should;

namespace NPoco.StoredProcedures.Tests.Unit
{
    public class QueryStoredProcedure
    {
        [TestFixture]
        public class when_testing_with_no_parameters
        {
            [Test]
            public void then_should_call_sp_with_sp_name()
            {
                // given
                var database = new DatabaseStub();

                // when
                database.QueryStoredProcedure<string>("MySpName");

                // then
                Sql executedSql = database.QuerySql;
                executedSql.SQL.ShouldContain("EXEC");
                executedSql.SQL.ShouldContain("MySpName");
            }

            [Test]
            public void then_should_not_have_any_arguements()
            {
                // given
                var database = new DatabaseStub();

                // when
                database.QueryStoredProcedure<string>("MySpName");

                // then
                Sql executedSql = database.QuerySql;
                executedSql.Arguments.ShouldBeEmpty();
            }

            [Test]
            public void then_should_return_expected_result()
            {
                // given
                var database = new DatabaseStub { QueryResult = new object[] { "Hello You" } };

                // when
                string[] result = database.QueryStoredProcedure<string>("MySpName").ToArray();

                // then
                result.ShouldNotBeEmpty();
                result[0].ShouldEqual("Hello You");
            }
        }

        [TestFixture]
        public class when_testing_with_one_parameter
        {
            [Test]
            public void then_should_include_paramter_in_sql()
            {
                // given
                var database = new DatabaseStub();

                // when
                database.QueryStoredProcedure<string>("MySpName", new Parameter("Param1", "Value"));

                // then
                Sql executedSql = database.QuerySql;
                executedSql.Arguments.ShouldNotBeEmpty();
                executedSql.Arguments.Any(x => x.Equals("Value")).ShouldBeTrue();

                executedSql.SQL.ShouldContain("Param1");
            }
        }

        [TestFixture]
        public class when_testing_with_multiple_parameters
        {
            [Test]
            public void then_should_include_paramter_in_sql()
            {
                // given
                var database = new DatabaseStub();

                // when
                database.QueryStoredProcedure<string>("MySpName", new Parameter("Param1", "Value"), new Parameter("Param2", "Value2"));

                // then
                Sql executedSql = database.QuerySql;
                executedSql.Arguments.ShouldNotBeEmpty();

                executedSql.SQL.ShouldContain("Param1");
                executedSql.Arguments.Any(x => x.Equals("Value")).ShouldBeTrue();

                executedSql.SQL.ShouldContain("Param2");
                executedSql.Arguments.Any(x => x.Equals("Value2")).ShouldBeTrue();
            }
        }
    }
}