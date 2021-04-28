using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Framework.Common
{
    public interface IXmlValueObjectRepository : IDisposable
    {
        T Find<T>(string code) where T : XmlValueObject;

        XmlValueObject Find(Type type, string code);

        T[] FindAll<T>() where T : XmlValueObject;

        IEnumerable<T> FindAll<T>(string codes) where T : XmlValueObject;

        XmlValueObject[] FindAll(Type type);
    }
}
