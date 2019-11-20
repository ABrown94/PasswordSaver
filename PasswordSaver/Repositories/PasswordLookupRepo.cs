using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PasswordSaver.Repositories
{
    class PasswordLookupRepo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        public App GetAppInfo(string name)
        {
            var info = (from i in db.Apps
                        where i.AppName.ToUpper() == name.ToUpper()
                        select i).FirstOrDefault();
            return info;
        }
    }
}