using Microsoft.AspNetCore.Http;
namespace DevConsulting.Common.Models.Extensions;
public static class SessionExtensions
    {
        public static long GetLong(this ISession session, string key)
        {    
            var sVal = session.GetString(key);
            long.TryParse(sVal, out long longVal);     
            return longVal;
        }
    }