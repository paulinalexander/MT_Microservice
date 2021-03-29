using System;
using System.Collections.Generic;
using System.Text;

namespace MT.OnlineRestuarant.DataLayer
{
   public class ApplicationString
    {
        private string _Db = "Server=patric\\SQLEXPRESS;Database=CustomerManagement;Trusted_Connection=True;MultipleActiveResultSets=true";
        public string DB
        {
            get
            {
                return _Db;
            }
            set
            {
                _Db = value;
            }
        }
    }
}
