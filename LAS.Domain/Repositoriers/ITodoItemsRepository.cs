﻿using LAS.Domain.Models;

namespace LAS.Domain.Repositoriers
{
    public interface ITodoItemsRepository
    {
        /// <summary>
        /// TODOアイテムを取得する (SqlDataReaderを使用)
        /// </summary>
        /// <returns></returns>
        List<TodoItems> FindWithSqlDataReader();

        /// <summary>
        /// TODOアイテムを取得する (データテーブルを使用)
        /// </summary>
        /// <returns></returns>
        List<TodoItems> FindWithDataTable();
    }
}