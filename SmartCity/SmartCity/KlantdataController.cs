using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity
{
    class KlantdataController
    {
        private DatabaseLinQDataContext db;
        public KlantdataController(DatabaseLinQDataContext db)
        {
            this.db = db;
        }

        public List<klantdata> getklantdata()
        {
            var klantdatacharts = (from klantdata in db.klantdatas
                          select klantdata).ToList();
            return klantdatacharts;
        }
    }
}
