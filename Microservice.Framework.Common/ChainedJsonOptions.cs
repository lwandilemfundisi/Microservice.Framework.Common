using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public class ChainedJsonOptions : IJsonOptions
    {
        private readonly Action<JsonSerializerSettings> _action;
        private readonly IJsonOptions _parent;

        public ChainedJsonOptions(IJsonOptions parent, Action<JsonSerializerSettings> action)
        {
            _parent = parent;
            _action = action;
        }

        void IJsonOptions.Apply(JsonSerializerSettings settings)
        {
            _parent.Apply(settings);
            _action.Invoke(settings);
        }
    }
}
