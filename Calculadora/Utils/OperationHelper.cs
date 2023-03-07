using Npgsql;
using System.Collections.Generic;

namespace Calculadora.Utils
{
    public class OperationHelper
    {
        public static IEnumerable<object[]> GetSumAdditionalData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=control123;Database=Operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"SumAdditionData\"";
                var npgsqlCommand = new NpgsqlCommand(query, connection);

                var dataReader = npgsqlCommand.ExecuteReader();
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];
                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }

                return tableData;
            }
        }

        public static IEnumerable<object[]> GetSubstractAdditionalData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=control123;Database=Operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"SubstractAdditionData\"";
                var npgsqlCommand = new NpgsqlCommand(query, connection);

                var dataReader = npgsqlCommand.ExecuteReader();
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];
                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }

                return tableData;
            }
        }

        public static IEnumerable<object[]> GetMultiplyAdditionalData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=control123;Database=Operations";
            List<object[]> tableData = new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"MultiplyAdditionData\"";
                var npgsqlCommand = new NpgsqlCommand(query, connection);

                var dataReader = npgsqlCommand.ExecuteReader();
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];
                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }

                return tableData;
            }
        }

        public static IEnumerable<object[]> GetDivideAdditionalData()
        {
            var connectionString = "Host=localhost;Username=postgres;Password=control123;Database=Operations";
            List<object[]> tableData= new List<object[]>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"DivideAdditionData\"";
                var npgsqlCommand = new NpgsqlCommand(query, connection);

                var dataReader = npgsqlCommand.ExecuteReader();
                var fieldCount = dataReader.FieldCount;

                while (dataReader.Read())
                {
                    object[] fieldValues = new object[fieldCount];
                    int instances = dataReader.GetValues(fieldValues);
                    tableData.Add(fieldValues);
                }

                return tableData;
            }
        }


    }
}
