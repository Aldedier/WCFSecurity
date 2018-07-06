using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSecurity
{
    public class SecurityServices : ISecurity
    {
        public ResponseModel AddRole(string username, string role)
        {
            throw new NotImplementedException();
        }

        public ResponseModel ChagePassword(string username, string actualPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public ResponseModel CreateUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string GetToken(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
