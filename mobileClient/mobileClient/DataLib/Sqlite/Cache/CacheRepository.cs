﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataLib.Sqlite.Model;
using SQLite;

namespace DataLib.Sqlite.Cache
{
    public class CacheRepository
    {
        private readonly SQLiteConnection cache;
        public CacheRepository(string databasePath)
        {
            cache = new SQLiteConnection(databasePath);
            cache.CreateTable<CalculatorCache>();
        }
        public IEnumerable<CalculatorCache> GetItems()
        {
            return cache.Table<CalculatorCache>().ToList();
        }
        public CalculatorCache GetItem(int id)
        {
            return cache.Get<CalculatorCache>(id);
        }
        public int DeleteItem(int id)
        {
            return cache.Delete<CalculatorCache>(id);
        }
        public int DeleteCache()
        {
            return cache.DeleteAll<CalculatorCache>();
        }

        public int SaveItem(CalculatorCache item)
        {
            if (item.Id == 0)
            {
                item.Id = NewId();
            }
            return cache.Insert(item);
        }
        public int NewId()
        {
            if (!GetItems().Any())
                return 1;
            return GetItems().Max(_ => _.Id) + 1;
        }
    }
}
