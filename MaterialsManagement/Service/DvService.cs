using MaterialsManagement.Model;
using MaterialsManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Service
{
    public class DvService
    {
        public List<Dv> GetAll()
        {
            return new DvRepository().GetAll();
        }

        public List<Dv> GetByQkId(string QkId)
        {
            return new DvRepository().GetByQkId(QkId);
        }

        public Dv Get(string DvId)
        {
            return new DvRepository().Get(DvId);
        }
        public Dv Add(Dv dv)
        {
            return new DvRepository().Insert(dv);
        }
        public void Update(Dv dv)
        {
            new DvRepository().Update(dv);
        }
    }
}
