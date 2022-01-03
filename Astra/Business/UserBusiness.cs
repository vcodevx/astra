using Astra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Business
{
    public class UserBusiness
    {
        private readonly AstraContext _astraContext = null;
        public UserBusiness(AstraContext astraContext)
        {
            _astraContext = astraContext;
        }

        public User CheckUserValidation(string username, string password)
        {
            var user = new UserRepository(_astraContext).Get(x => x.UserName == username 
            && x.UserPassword == password).FirstOrDefault();

            if (user != null)
                user.UserPassword = null;

            return user;

        }
    }
}
