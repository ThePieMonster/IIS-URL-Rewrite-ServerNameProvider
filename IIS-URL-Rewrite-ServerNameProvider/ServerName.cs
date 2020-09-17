using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Iis.Rewrite;

namespace IIS_URL_Rewrite_ServerNameProvider
{
    public class ServerName : IRewriteProvider
    {
        public void Initialize(IDictionary<string, string> settings, IRewriteContext rewriteContext)
        {
        }

        public string Rewrite(string value)
        {
            return System.Environment.MachineName;
        }
    }
}