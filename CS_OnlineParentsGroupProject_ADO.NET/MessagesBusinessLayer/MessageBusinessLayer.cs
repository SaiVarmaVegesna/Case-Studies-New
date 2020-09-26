using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineParentDAL;
using OnlineParentEntities;

namespace MessagesBusinessLayer
{
    public class MessageBusinessLayer
    {
        public void PostMessage(string parentName, string subject, string message)
        {
            AdoConnected dal = new AdoConnected();
            dal.PostMessage(parentName, subject, message);

        }
        public void GetMessagesBySubject(string sub)
        {
            AdoConnected dal = new AdoConnected();
            dal.GetMessagesBySubject(sub);

        }
        public List<Messages> GetAllSubjects(string sub)
        {
            AdoConnected dal = new AdoConnected();
            List<Messages> lstMsg = dal.GetAllSubjects(sub);
            return lstMsg;
        }
    }
}
