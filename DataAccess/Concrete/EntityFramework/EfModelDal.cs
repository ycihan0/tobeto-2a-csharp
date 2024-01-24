using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    internal class EfModelDal : ITransmissionDal
    {
        public Model Add(Model entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Add(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Model Delete(Model entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Delete(Transmission entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Delete(Transmission entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Model? Get(Func<Model, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Transmission? Get(Func<Transmission, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetList(Func<Model, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IList<Transmission> GetList(Func<Transmission, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Model Update(Model entity)
        {
            throw new NotImplementedException();
        }

        public Transmission Update(Transmission entity)
        {
            throw new NotImplementedException();
        }

     
    }
}
