﻿using Arke.Salesforce.Common.Models;

namespace Arke.Salesforce.Common
{
    public class ForceAuthException : ForceException
    {
        public ForceAuthException(string error, string description) : base(error, description)
        {
        }

        public ForceAuthException(string error, string description, string[] fields) : base(error, description, fields)
        {
        }

        public ForceAuthException(Error error, string description, string[] fields) : base(error, description, fields)
        {
        }

        public ForceAuthException(Error error, string description) : base(error, description)
        {
        }
    }
}