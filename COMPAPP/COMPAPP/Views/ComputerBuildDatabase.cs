using COMPAPP.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace COMPAPP.Views
{
    public class ComputerBuildDatabase
    {
        SQLiteConnection database;

        public ComputerBuildDatabase(string dbPath)
        {
            database = new SQLiteConnection(dbPath);
            database.CreateTable<ComputerBuild>();
        }

        public List<ComputerBuild> GetComputerBuilds()
        {
            return database.Table<ComputerBuild>().ToList();
        }

        public ComputerBuild GetComputerBuildById(int id)
        {
            return database.Get<ComputerBuild>(id);
        }

        public void AddComputerBuild(ComputerBuild build)
        {
            database.Insert(build);
        }
    }
}
