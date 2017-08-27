﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class ProtocolCreator
    {
        public static Protocol RegistrationRequest(string username, string password)
        {
            byte[] userData = Encoding.ASCII.GetBytes(username + "-" + password);
            return new Protocol(ProtocolTypes.RegistrationRequest, userData);
        }

        public static Protocol LoginRequest(string username, string password)
        {
            byte[] userData = Encoding.ASCII.GetBytes(username + "-" + password);
            return new Protocol(ProtocolTypes.LoginRequest, userData);
        }

        public static Protocol SessionData(string username, string sessionKey)
        {
            byte[] sessionData = Encoding.ASCII.GetBytes(username + "-" + sessionKey);
            return new Protocol(ProtocolTypes.SessionData, sessionData);
        }
    }
}
