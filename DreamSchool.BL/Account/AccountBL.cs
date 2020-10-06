using DreamSchool.BO.Account;
using DreamSchool.DA.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamSchool.BL.Account
{
    public class AccountBL
    {
        public LoginBO AuthenticateUser(LoginBO objlogin)
        {
            return new AccountDA().AuthenticateUser(objlogin);
        }
    }
}
