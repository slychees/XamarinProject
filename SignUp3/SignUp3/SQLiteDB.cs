using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamlMobileAppProject
{
    class SQLiteDB
    {
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get;
            set;
        }
        [MaxLength(30)]
        public string Surname
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string FirstName
        {
            get;
            set;
        }
        [MaxLength(20)]
        public string MiddleName
        {
            get;
            set;
        }
        [MaxLength(8)]
        public string SID
        {
            get;
            set;
        }
        public SQLiteDB()
        {

        }
    }

}
