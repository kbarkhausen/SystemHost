using System.Collections;

namespace SystemHost.Web
{
    public interface IHttpContext
    {
        HttpContextContents Current { get; set; }
    }

    public class HttpContext : IHttpContext
    {
        private HttpContextContents _contents;

        public HttpContextContents Current
        {
            get
            {
                if (_contents == null)
                    _contents = new HttpContextContents();
                return _contents;
            }
            set { _contents = value; }
        }
    }

    public class HttpContextContents
    {       

        private System.Web.HttpRequest _request;
        public System.Web.HttpRequest Request
        {
            get
            {
                if (_request == null)
                    _request = System.Web.HttpContext.Current.Request;
                return _request;
            }
            set { _request = value; }
        }

        private System.Web.HttpResponse _response;
        public System.Web.HttpResponse Response
        {
            get
            {
                if (_response == null)
                    _response = System.Web.HttpContext.Current.Response;
                return _response;
            }
            set { _response = value; }
        }

        private IDictionary _items;
        public IDictionary Items
        {
            get
            {
                if (_items == null)
                    _items = System.Web.HttpContext.Current.Items;
                return _items;
            }
            set { _items = value; }
        }

        private System.Security.Principal.IPrincipal _user;
        public System.Security.Principal.IPrincipal User
        {
            get
            {
                if (_user == null)
                    _user = System.Web.HttpContext.Current.User;
                return _user;
            }
            set { _user = value; }
        }

        private System.Web.HttpServerUtility _server;
        public System.Web.HttpServerUtility Server
        {
            get
            {
                if (_server == null)
                    _server = System.Web.HttpContext.Current.Server;
                return _server;
            }
            set { _server = value; }
        }
    }
}
