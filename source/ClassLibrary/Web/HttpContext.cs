using System.Collections;
using System.Security.Principal;

namespace System.Web
{
    public interface IHttpContextProxy
    {
        HttpContextContents Current { get; set; }
    }

    public class HttpContextProxy : IHttpContextProxy
    {
        private HttpContextContents _contents;        

        public HttpServerUtility Server
        {
            get
            {
                return Current.Server;
            }
            set { _contents.Server = value; }
        }

        public IDictionary Items
        {
            get
            {
                return Current.Items;
            }
            set { _contents.Items = value; }
        }

        public HttpRequest Request
        {
            get
            {
                return Current.Request;
            }
            set { _contents.Request = value; }
        }

        public HttpResponse Response
        {
            get
            {
                return Current.Response;
            }
            set { _contents.Response = value; }
        }      
  
        public IPrincipal User
        {
            get
            {
                return Current.User;
            }
            set { _contents.User = value; }
        }  

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

        private HttpRequest _request;
        public HttpRequest Request
        {
            get
            {
                if (_request == null)
                    _request = HttpContext.Current.Request;
                return _request;
            }
            set { _request = value; }
        }

        private HttpResponse _response;
        public HttpResponse Response
        {
            get
            {
                if (_response == null)
                    _response = HttpContext.Current.Response;
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
                    _items = HttpContext.Current.Items;
                return _items;
            }
            set { _items = value; }
        }

        private IPrincipal _user;
        public IPrincipal User
        {
            get
            {
                if (_user == null)
                    _user = HttpContext.Current.User;
                return _user;
            }
            set { _user = value; }
        }

        private HttpServerUtility _server;
        public HttpServerUtility Server
        {
            get
            {
                if (_server == null)
                    _server = HttpContext.Current.Server;
                return _server;
            }
            set { _server = value; }
        }
    }
}
