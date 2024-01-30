using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CorporateCustomerBusinessRules
    {
        private readonly ICorporateCustomer _corporateCustomer;

        public CorporateCustomerBusinessRules(ICorporateCustomer corporateCustomer)
        {
            _corporateCustomer = corporateCustomer;
        }
    }
}
