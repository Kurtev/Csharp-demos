using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.VersionAttribute
{
    [AttributeUsage( AttributeTargets.Class | AttributeTargets.Field|AttributeTargets.Property | AttributeTargets.Method)]

    public class VersionAttribute : Attribute
    {
        

        public VersionAttribute(string ver)
        {
            this.Version = ver;
        }

        public string Version { get; private set; }
    }
}