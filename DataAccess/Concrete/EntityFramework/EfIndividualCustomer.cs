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
    public class EfIndividualCustomer : EfEntityRepositoryBase<IndividualCustomer, int, RentACarContext>, IIndividualCustomerDal
    {
        public EfIndividualCustomer(RentACarContext context) : base(context)
        {
        }
    }
}
