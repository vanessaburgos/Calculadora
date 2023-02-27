using Npgsql;
using System;
using System.Collections.Generic;

namespace Calculadora.Utils
{
    public class OperationHelper
    {
        public static IEnumerable<object[]> GetSumAdditionalData()
        {
            var cs = "Host=localhost;Username=postgres;Password=control123;Database=operations";

            using (var connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"SumAdditionData\"";
                var cmd = new NpgsqlCommand(query, connection);
                var testData = cmd.ExecuteReader();
                Console.WriteLine($"PostgreSQL version: {testData.ToString()}");
            }

            return new[]
            {
                new object[] {1, 2, 3 },
                new object[] {-2, -3, -5 },
                new object[] {-7, -3, -10 },
                new object[] { 12, -8, 4},
                new object[] { 0, 1, 1},
                new object[] { 9, 0, 9},
                new object[] {-9, 0, -9},
                new object[] { 0, -6, -6},
                new object[] { 0, 0, 0},
            };

        }

        public static IEnumerable<object[]> GetSubstractAdditionalData()
        {
            var cs = "Host=localhost;Username=postgres;Password=control123;Database=operations";

            using (var connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"SubstractAdditionData\"";
                var cmd = new NpgsqlCommand(query, connection);
                var testData = cmd.ExecuteReader();
                Console.WriteLine($"PostgreSQL version: {testData.ToString()}");
            }

            return new[]
            {
                new object[] { 4, 1, 3 },
                new object[] { -3, -2, -1 },
                new object[] { 7, -3, 10 },
                new object[] { -12, 8, -20 },
                new object[] { 0, 1, -1 },
                new object[] { 9, 0, 9 },
                new object[] { -9, 0, -9 },
                new object[] { 0, -6, 6 },
                new object[] { 0, 0, 0 },
            };
        }

        public static IEnumerable<object[]> GetMultiplyAdditionalData()
        {
            var cs = "Host=localhost;Username=postgres;Password=control123;Database=operations";

            using (var connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"MultiplyAdditionData\"";
                var cmd = new NpgsqlCommand(query, connection);
                var testData = cmd.ExecuteReader();
                Console.WriteLine($"PostgreSQL version: {testData.ToString()}");
            }

            return new[]
            {
                new object[] { 8, 1, 8 },
                new object[] { -3, -2, 6 },
                new object[] { 7, -3, -21 },
                new object[] { -12, 8, -96 },
                new object[] { 0, 1, 0 },
                new object[] { 9, 0, 0 },
                new object[] { -9, 0, 0 },
                new object[] { 0, -6, 0 },
                new object[] { 0, 0, 0 },
            };
        }

        public static IEnumerable<object[]> GetDivideAdditionalData()
        {
            var cs = "Host=localhost;Username=postgres;Password=control123;Database=Operations";


            using (var connection = new NpgsqlConnection(cs))
            {
                connection.Open();
                var query = "SELECT * FROM public.\"DivideAdditionData\"";
                var cmd = new NpgsqlCommand(query, connection);
                var testData = cmd.ExecuteNonQuery();
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"PostgreSQL version: {reader.ToString()}");
                    }
                }
            }
            
            return new[]
            {
                new object[] { 22, 2, 11 },
                new object[] { -10, -5, 2 },
                new object[] { 30, -3, -10},
                new object[] { -12, 6, -2 },
                new object[] { 0, 6, 0 },
                new object[] { 0, -8, 0 },
            };
            
        }
    }
}
