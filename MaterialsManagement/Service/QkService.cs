using MaterialsManagement.Model;
using MaterialsManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialsManagement.Service
{
    public class QkService
    {
        public List<Qk> GetAll()
        {
            return new QkRepository().GetAll();
        }
        public Qk Get(string Id)
        {
            return new QkRepository().Get(Id);
        }
        public Qk Add(Qk qk)
        {

            return new QkRepository().Insert(qk);
        }
        public void Update(Qk qk)
        {
            new QkRepository().Update(qk);
        }
        public void Clear()
        {
            QkRepository qkRepository = new QkRepository();
            qkRepository.TurnOffContaint();
            qkRepository.Clear();
            qkRepository.TurnOnContaint();

        }
    }
}
