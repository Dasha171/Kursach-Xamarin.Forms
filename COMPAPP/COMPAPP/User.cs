using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerApp
{
    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(255)]
        public string Username { get; set; }

        [MaxLength(255)]
        public string Password { get; set; }

    }
}

