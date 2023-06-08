using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void AddT(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void DeleteT(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
        }

        public void UpdateT(Writer t)
        {
            _writerdal.Update(t);
        }
    }
}
