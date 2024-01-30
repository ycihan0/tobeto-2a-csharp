using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class UserBusinessRules
    {
        private readonly IUserDal _userDal;

        public UserBusinessRules(IUserDal userDal)
        {
            _userDal = userDal;
        }

        //public void CheckIfUserNameNotExists(string userName)
        //{
        //    bool isExists = _userDal.Get(user => user.Name == userName) is not null;
        //    if (isExists)
        //    {
        //        throw new BusinessException("Brand already exists.");
        //    }
        //}

        //Aynı isimde farklı kullanıcı adı olabileceğini düşündüğüm için bu kontrolu kaldırdım.
    }
    
}
