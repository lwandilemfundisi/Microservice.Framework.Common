using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ValueObjectResourcePathAttribute : Attribute
    {
        #region Constructors

        public ValueObjectResourcePathAttribute(string path)
        {
            Invariant.ArgumentNotEmpty(path, () => "path is required");
            Path = path;
        }

        #endregion

        #region Properties

        public string Path { get; private set; }

        #endregion
    }
}
