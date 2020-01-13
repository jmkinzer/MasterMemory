// <auto-generated />
using ConsoleApp;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Buffers;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq.Expressions;
using System.Linq;
using System.Reflection;
using System;
using ConsoleApp.Tables;

namespace ConsoleApp
{
   public static class MetaMemoryDatabase
   {
        static MasterMemory.Meta.MetaDatabase metaTable;

        public static object GetTable(MemoryDatabase db, string tableName)
        {
            switch (tableName)
            {
                case "monster":
                    return db.MonsterTable;
                case "person":
                    return db.PersonTable;
                case "quest_master":
                    return db.QuestTable;
                case "item":
                    return db.ItemTable;
                case "Test1":
                    return db.Test1Table;
                case "Test2":
                    return db.Test2Table;
                
                default:
                    return null;
            }
        }

        public static MasterMemory.Meta.MetaDatabase GetMetaDatabase()
        {
            if (metaTable != null) return metaTable;

            var dict = new Dictionary<string, MasterMemory.Meta.MetaTable>();
            dict.Add("monster", ConsoleApp.Tables.MonsterTable.CreateMetaTable());
            dict.Add("person", ConsoleApp.Tables.PersonTable.CreateMetaTable());
            dict.Add("quest_master", ConsoleApp.Tables.QuestTable.CreateMetaTable());
            dict.Add("item", ConsoleApp.Tables.ItemTable.CreateMetaTable());
            dict.Add("Test1", ConsoleApp.Tables.Test1Table.CreateMetaTable());
            dict.Add("Test2", ConsoleApp.Tables.Test2Table.CreateMetaTable());

            metaTable = new MasterMemory.Meta.MetaDatabase(dict);
            return metaTable;
        }
    }
}