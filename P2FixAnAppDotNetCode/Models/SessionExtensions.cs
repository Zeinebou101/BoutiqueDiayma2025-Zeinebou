using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace P2FixAnAppDotNetCode.Models
{
    public static class SessionExtensions
    {
        public static void SetObject<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var str = session.GetString(key);
            return str == null ? default(T) : JsonConvert.DeserializeObject<T>(str);
        }
    }
}