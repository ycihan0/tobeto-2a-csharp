﻿using Core.DataAccess.InMemory;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTransmissionDal : InMemoryEntityRepositoryBase<Transmission, int>, ITransmissionDal
    {
        protected override int generateId()
        {
            int nextId = Entities.Count == 0
                 ? 1
                 : Entities.Max(e => e.Id) + 1;
            return nextId;
        }
    }
}
