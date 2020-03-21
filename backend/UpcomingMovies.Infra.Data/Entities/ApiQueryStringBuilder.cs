using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using UpcomingMovies.Infra.Data.Enum;

namespace UpcomingMovies.Infra.Data.Entities
{
    public class ApiQueryStringBuilder
    {
        private readonly List<string> queryString;


        public ApiQueryStringBuilder()
        {
            queryString = new List<string>();
        }

        public ApiQueryStringBuilder Equal(QueryStringField field, string value)
        {
            var encodedValue = HttpUtility.UrlEncode(value);
            var filter = $"{field}={encodedValue}";

            queryString.Add(filter);
            return this;
        }

        public ApiQueryStringBuilder Equal(QueryStringField field, int value)
                                       => Equal(field, value.ToString());



        public override string ToString() => string.Join("&", queryString);
    }
}
