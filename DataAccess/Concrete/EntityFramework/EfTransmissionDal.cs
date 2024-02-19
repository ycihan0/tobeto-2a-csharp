﻿using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTransmissionDal : EfEntityRepositoryBase<Transmission, int, RentACarContext>, ITransmissionDal
    {
        public EfTransmissionDal(RentACarContext context) : base(context)
        {
        }
    }
}
