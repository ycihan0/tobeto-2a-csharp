﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    internal class EfFuelDal : IFuelDal
    {
        public Fuel Add(Fuel entity)
        {
            throw new NotImplementedException();
        }

        public Fuel Delete(Fuel entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public Fuel? Get(Func<Fuel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Fuel> GetList(Func<Fuel, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public Fuel Update(Fuel entity)
        {
            throw new NotImplementedException();
        }
    }
}
