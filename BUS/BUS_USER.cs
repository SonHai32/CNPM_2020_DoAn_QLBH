using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_USER
    {
        public DTO.DTO_CUser userLogin(DTO.DTO_CUser user)
        {
            return new DAL_User().userLogin(user);
        }
    }
}
