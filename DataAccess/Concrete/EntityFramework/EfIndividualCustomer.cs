﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIndividualCustomer : IIndividualCustomerDal
    {
        public IndividualCustomer Add(IndividualCustomer entity)
        {
            throw new NotImplementedException();
        }

        public IndividualCustomer Delete(IndividualCustomer entity, bool isSoftDelete = true)
        {
            throw new NotImplementedException();
        }

        public IndividualCustomer? Get(Func<IndividualCustomer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<IndividualCustomer> GetList(Func<IndividualCustomer, bool>? predicate = null)
        {
            throw new NotImplementedException();
        }

        public IndividualCustomer Update(IndividualCustomer entity)
        {
            throw new NotImplementedException();
        }
    }
}
