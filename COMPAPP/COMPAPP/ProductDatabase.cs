using System;
using System.Collections.Generic;
using System.Text;
using COMPAPP.Views;
using System.Threading.Tasks;
using SQLite;

namespace COMPAPP
{
    public class ProductDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ProductDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return _database.Table<Product>().ToListAsync();
        }

        public Task<int> SaveProductAsync(Product product)
        {
            if (product.ID != 0)
            {
                return _database.UpdateAsync(product);
            }
            else
            {
                return _database.InsertAsync(product);
            }
        }
    }
}
