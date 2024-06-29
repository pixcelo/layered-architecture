﻿using LAS.Domain.Models;
using LAS.Infrastructure.SQLServer;
using System.Data;
using System.Data.SqlClient;

namespace LAS.Domain.Repositoriers
{
    public class TodoItemsRepository : ITodoItemsRepository
    {
        public List<TodoItems> FindWithSqlDataReader()
        {
            var list = new List<TodoItems>();
            var query = "SELECT * FROM TodoItems";

            using (var connection = new SqlConnection(
                SQLServerHelper.GetConnectionStringWithWindowsAuth("(localdb)\\MSSQLLocalDB","LAS")))
            using (var command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TodoItems
                        {
                            // インデックスで指定
                            //Id = reader.GetInt64(0),
                            //Title = reader.GetString(1),
                            //Description = reader.GetString(2),
                            //IsComplete = reader.GetBoolean(3),
                            //DueDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                            //CreatedAt = reader.GetDateTime(5),
                            //UpdatedAt = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                            //DeletedAt = reader.IsDBNull(7) ? (DateTime?)null : reader.GetDateTime(7)

                            // 項目名で指定
                            Id = reader.GetInt64("Id"),
                            Title = reader.GetString("Title"),
                            Description = reader.GetString("Description"),
                            IsComplete = reader.GetBoolean("IsComplete"),
                            DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? (DateTime?)null : reader.GetDateTime("DueDate"),
                            CreatedAt = reader.GetDateTime("CreatedAt"),
                            UpdatedAt = reader.IsDBNull(reader.GetOrdinal("UpdatedAt")) ? (DateTime?)null : reader.GetDateTime("UpdatedAt"),
                            DeletedAt = reader.IsDBNull(reader.GetOrdinal("DeletedAt")) ? (DateTime?)null : reader.GetDateTime("DeletedAt")
                        });
                    }
                }
            }

            return list;
        }

        public List<TodoItems> FindWithDataTable()
        {
            var list = new List<TodoItems>();
            var query = "SELECT * FROM TodoItems";

            var dataTable = new DataTable();
            using (var connection = new SqlConnection(
                SQLServerHelper.GetConnectionStringWithWindowsAuth("(localdb)\\MSSQLLocalDB","LAS")))
            using (var adapter = new SqlDataAdapter(query, connection))
            {
                adapter.Fill(dataTable);

                list = dataTable.AsEnumerable().Select(row =>
                    new TodoItems
                    {
                        Id = row.Field<long>("Id"),
                        Title = row.Field<string>("Title"),
                        Description = row.Field<string>("Description"),
                        IsComplete = row.Field<bool>("IsComplete"),
                        DueDate = row.Field<DateTime?>("DueDate"),
                        CreatedAt = row.Field<DateTime>("CreatedAt"),
                        UpdatedAt = row.Field<DateTime?>("UpdatedAt"),
                        DeletedAt = row.Field<DateTime?>("DeletedAt")
                    }).ToList();
            }

            return list;
        }        
    }
}
