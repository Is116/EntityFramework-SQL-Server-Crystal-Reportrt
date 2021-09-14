using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace project_2
{
    class dbaccess
    {
        public interntbl model = new interntbl();

        public void saveData(int id,string name,string gender,string married,string idproof,string dt)
        {
            using (dbEntities db = new dbEntities())
            {
                model.id = id;
                model.name = name;
                model.gender = gender;
                model.married = married;
                model.idproof = idproof;
                model.dob = dt;

                db.interntbls.Add(model);
                db.SaveChanges();
            }
        }
        

    }
}
