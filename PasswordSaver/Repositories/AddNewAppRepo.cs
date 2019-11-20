using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PasswordSaver.Repositories
{
    class AddNewAppRepo
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public bool checkIfUnique(string name)
        {
            bool isUnique = true;
            App app = (from a in db.Apps
                       where a.AppName.ToLower() == name.ToLower()
                       select a).Single();
            if(app != null)
            {
                isUnique = false;
            }
            return isUnique;
        }
        public void AddNewApp(App newApp)
        {
            db.Apps.InsertOnSubmit(newApp);
            db.SubmitChanges();
        }
        public void EditApp(string name, string username, string password)
        {
            App app = (from a in db.Apps
                       where a.AppName.ToLower() == name.ToLower()
                       select a).Single();
            if(username != null)
            {
                app.Username = username;
            }
            if(password != null)
            {
                app.Password = password;
            }
            db.SubmitChanges();
        }

        public void DeleteApp(string name)
        {
            App app = (from a in db.Apps
                       where a.AppName.ToLower() == name.ToLower()
                       select a).Single();
            db.Apps.DeleteOnSubmit(app);
            db.SubmitChanges();
        }
    }
}
