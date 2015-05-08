using System;
using System.Web.Mvc;

namespace WebApp.Controllers
{

    public class HomeModel
    {
        public DateTime DateTime { get; set; }
        public string ServerMapPath { get; set; }
        public string CurrentServerMapPath { get; set; }
        public int ItemsCount { get; set; }
        public int CurrentItemsCount { get; set; }
        public int RequestQueryString1 { get; set; }
        public int RequestQueryString2 { get; set; }
        public string ApplicationSetting { get; set; }
        public string ConnectionString { get; set; }
        public string DirectoryPath { get; set; }
        public string FilePath { get; set; }
        public bool DirectoryExists { get; set; }
        public bool FileExists { get; set; }
    }

    public class HomeController : Controller
    {
        
        private DateTimeProxy _dateTimeProxy;
        public DateTimeProxy DateTimeProxy
        {
            get
            {
                if (_dateTimeProxy == null) 
                    _dateTimeProxy = new DateTimeProxy();
                return _dateTimeProxy;
            }
            set { _dateTimeProxy = value; }
        }

        private System.Web.HttpContextProxy _httpContextProxy;
        public System.Web.HttpContextProxy HttpContextProxy
        {
            get
            {
                if (_httpContextProxy == null)
                    _httpContextProxy = new System.Web.HttpContextProxy();
                return _httpContextProxy;
            }
            set { _httpContextProxy = value; }
        }

        private System.IO.FileProxy _fileProxy;
        public System.IO.FileProxy FileProxy
        {
            get
            {
                if (_fileProxy == null)
                    _fileProxy = new System.IO.FileProxy();
                return _fileProxy;
            }
            set { _fileProxy = value; }
        }

        private System.IO.DirectoryProxy _directoryProxy;
        public System.IO.DirectoryProxy DirectoryProxy
        {
            get
            {
                if (_directoryProxy == null)
                    _directoryProxy = new System.IO.DirectoryProxy();
                return _directoryProxy;
            }
            set { _directoryProxy = value; }
        }

        private System.Configuration.ConfigurationManagerProxy _configurationManagerProxy;
        public System.Configuration.ConfigurationManagerProxy ConfigurationManagerProxy
        {
            get
            {
                if (_configurationManagerProxy == null)
                    _configurationManagerProxy = new System.Configuration.ConfigurationManagerProxy();
                return _configurationManagerProxy;
            }
            set { _configurationManagerProxy = value; }
        }

        public ActionResult Index()
        {
            var model = new HomeModel();

            model.DateTime = DateTimeProxy.Now;

            model.ServerMapPath = new System.Web.HttpContextProxy().Server.MapPath("/");
            model.CurrentServerMapPath = new System.Web.HttpContextProxy().Current.Server.MapPath("/");

            model.ItemsCount = HttpContextProxy.Items.Count;
            model.CurrentItemsCount = HttpContextProxy.Current.Items.Count;

            model.RequestQueryString1 = HttpContextProxy.Request.QueryString.Count;
            model.RequestQueryString2 = HttpContextProxy.Current.Request.QueryString.Count;

            var configurationManagerProxy = new System.Configuration.ConfigurationManagerProxy();

            model.ApplicationSetting = configurationManagerProxy.AppSettings["item1"];
            model.ConnectionString = configurationManagerProxy.ConnectionStrings["DefaultConnection"].ConnectionString;

            model.DirectoryPath = HttpContextProxy.Server.MapPath("/") + "TestDirectory";
            model.FilePath = model.DirectoryPath + @"\" + "TestFile.txt";
            
            model.DirectoryExists = DirectoryProxy.Exists(model.DirectoryPath);
            
            model.FileExists = FileProxy.Exists(model.FilePath);

            model.ApplicationSetting = ConfigurationManagerProxy.AppSettings["item1"];

            model.ConnectionString = ConfigurationManagerProxy.ConnectionStrings["DefaultConnection"].ConnectionString;

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}