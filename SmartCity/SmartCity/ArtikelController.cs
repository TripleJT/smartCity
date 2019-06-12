using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity
{
    class ArtikelController
    {
        private DatabaseLinQDataContext db;
        public ArtikelController(DatabaseLinQDataContext db)
        {
            this.db = db;
        }

        public List<artikel> getartikeldata()
        {
            var artikeldatacharts = (from artikel in db.artikels
                                   select artikel).ToList();
            return artikeldatacharts;
        }
    }
}
