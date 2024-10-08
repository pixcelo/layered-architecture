﻿using LAS.Domain.Models;

namespace LAS.Domain.Repositoriers
{
    public interface ITodoItemsRepository
    {
        /// <summary>
        /// TODOアイテムを取得する (SqlDataReaderを使用)
        /// </summary>
        /// <returns></returns>
        List<TodoItem> FindWithSqlDataReader();

        /// <summary>
        /// TODOアイテムを取得する (データテーブルを使用)
        /// </summary>
        /// <returns></returns>
        List<TodoItem> FindWithDataTable();

        /// <summary>
        /// TODOアイテムを取得する (Dapperを使用)
        /// </summary>
        /// <returns></returns>
        List<TodoItem> FindWithDapper();

        /// <summary>
        /// TODOアイテムを追加する
        /// </summary>
        /// <param name="todoItems"></param>
        void Insert(TodoItem todoItems);

        /// <summary>
        /// TODOアイテムを追加する (Dapperを使用)
        /// </summary>
        /// <param name="todoItem"></param>
        void InsertWithDapper(TodoItem todoItem);

        /// <summary>
        /// TODOアイテムを更新する
        /// </summary>
        /// <param name="todoItems"></param>
        int Update(TodoItem todoItems);

        /// <summary>
        /// TOODアイテムを追加または更新する
        /// </summary>
        /// <param name="todoItems"></param>
        void Upsert(TodoItem todoItems);

        /// <summary>
        /// TODOアイテムを削除する
        /// </summary>
        /// <param name="id"></param>
        void Delete(long id);
    }
}