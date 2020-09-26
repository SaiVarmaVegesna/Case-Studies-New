using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineParentDAL;
using OnlineParentEntities;

namespace OnlineParentBusinessLayer
{
    public class ParentBusinessLayer
    {
        public List<Parent> GetAllParent()
        {
            AdoConnected dal = new AdoConnected();
            List<Parent> lstParents = dal.GetAllParent();
            return lstParents;
        }
        public List<Messages> GetAllMessage()
        {
            AdoConnected dal = new AdoConnected();
            List<Messages> lstMessages = dal.GetAllMessage();
            return lstMessages;
        }

        public void RegisterUser(Parent p)
        {
            AdoConnected dal = new AdoConnected();
            dal.RegisterUser(p);
        }

        public int Checklogin(Parent p)
        {
            AdoConnected dal = new AdoConnected();
            int a = dal.Checklogin(p);
            return a;
        }

        public int CheckUserRegistration(Parent p)
        {
            AdoConnected dal = new AdoConnected();
            int b = dal.CheckUserRegistration(p);
            return b;
        }
    }
}
