using System.Collections.Specialized;
using System.Web;
using UpcomingMovies.Infra.Data.Enum;

namespace UpcomingMovies.Infra.Data.Api
{
    public class QueryStringBuilder
    {
        private readonly NameValueCollection queryString;

        public QueryStringBuilder()
        {
            queryString = HttpUtility.ParseQueryString("");
        }

        public QueryStringBuilder Equal<T>(QueryStringField field, T value)
        {
            var encodedValue = HttpUtility.UrlEncode(value.ToString());
            queryString.Add(field.ToString(), encodedValue);
            return this;
        }

        public override string ToString() => queryString.ToString();
    }
}
