using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Microservice.Framework.Common
{
    public static class NotificationExtensions
    {
        public static void AddError(this ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>> notifications, KeyValuePair<string, List<string>> propertyMessages)
        {
            notifications.AddNotification("errors", propertyMessages);
        }

        public static void AddWarning(this ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>> notifications, KeyValuePair<string, List<string>> propertyMessages)
        {
            notifications.AddNotification("warnings", propertyMessages);
        }

        public static void AddInformation(this ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>> notifications, KeyValuePair<string, List<string>> propertyMessages)
        {
            notifications.AddNotification("information", propertyMessages);
        }

        public static void AddNotification(this ConcurrentDictionary<string, ConcurrentDictionary<string, List<string>>> notifications, string key, KeyValuePair<string, List<string>> propertyMessages)
        {
            notifications[key].TryAdd(propertyMessages.Key, propertyMessages.Value);
        }

    }
}
