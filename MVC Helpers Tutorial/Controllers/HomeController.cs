using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MVC_Helpers_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            //string json = @'[{"Id":2,"DiscountName":"10 % off on burgers","Details":"10 % off on burgers","Enabled":true,"BranchId":11,"BranchName":"KFC F6","TermsAndConditions":null,"TenantId":2,"ImageId":52,"StartDateTime":"2017 - 07 - 21T16: 23:08","EndDateTime":"2017 - 08 - 20T16: 23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29},{"Id":2,"Title":"Visa Card","ImageId":30}],"Categories":[5],"Latitude":33.729264,"Longitude":73.074765,"IsLiked":false,"Tags":[]},{"Id":4,"DiscountName":"10 % off on mens kurtaz","Details":"10 % off on mens kurtaz","Enabled":true,"BranchId":14,"BranchName":"Khaadi Centaurus Mall","TermsAndConditions":null,"TenantId":2,"ImageId":54,"StartDateTime":"2017 - 07 - 21T16: 23:08","EndDateTime":"2017 - 08 - 20T16: 23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29},{"Id":2,"Title":"Visa Card","ImageId":30}],"Categories":[26],"Latitude":33.707779,"Longitude":73.049737,"IsLiked":false,"Tags":[]},{"Id":4,"DiscountName":"10 % off on mens kurtaz","Details":"10 % off on mens kurtaz","Enabled":true,"BranchId":8,"BranchName":"Khaadi F10","TermsAndConditions":null,"TenantId":2,"ImageId":54,"StartDateTime":"2017 - 07 - 21T16: 23:08","EndDateTime":"2017 - 08 - 20T16: 23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29},{"Id":2,"Title":"Visa Card","ImageId":30}],"Categories":[26],"Latitude":33.694586,"Longitude":73.014366,"IsLiked":false,"Tags":[]},{"Id":2,"DiscountName":"10 % off on burgers","Details":"10 % off on burgers","Enabled":true,"BranchId":10,"BranchName":"KFC F10","TermsAndConditions":null,"TenantId":2,"ImageId":52,"StartDateTime":"2017 - 07 - 21T16: 23:08","EndDateTime":"2017 - 08 - 20T16: 23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29},{"Id":2,"Title":"Visa Card","ImageId":30}],"Categories":[5],"Latitude":33.694286,"Longitude":73.013429,"IsLiked":false,"Tags":[]},{"Id":1,"DiscountName":"50 % off on Registration","Details":"50 % discount on registration fee for new customers for 1 month","Enabled":true,"BranchId":13,"BranchName":"World Gym F11","TermsAndConditions":null,"TenantId":2,"ImageId":51,"StartDateTime":"2017 - 07 - 21T16:23:08","EndDateTime":"2017 - 08 - 20T16:23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29},{"Id":2,"Title":"Visa Card","ImageId":30}],"Categories":[11],"Latitude":33.684827,"Longitude":72.989007,"IsLiked":true,"Tags":[]},{"Id":3,"DiscountName":"10 % off on master card","Details":"10 % off on master card","Enabled":true,"BranchId":2,"BranchName":"METRO Islamabad Store","TermsAndConditions":null,"TenantId":2,"ImageId":53,"StartDateTime":"2017 - 07 - 21T16:23:08","EndDateTime":"2017 - 08 - 20T16:23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29}],"Categories":[23,24],"Latitude":33.639700,"Longitude":73.025800,"IsLiked":false,"Tags":[]},{"Id":3,"DiscountName":"10 % off on master card","Details":"10 % off on master card","Enabled":true,"BranchId":3,"BranchName":"METRO Faisalabad Store","TermsAndConditions":null,"TenantId":2,"ImageId":53,"StartDateTime":"2017 - 07 - 21T16:23:08","EndDateTime":"2017 - 08 - 20T16:23:08","Channels":[],"CardTypes":[{"Id":1,"Title":"Master Card","ImageId":29}],"Categories":[23,24],"Latitude":31.508500,"Longitude":73.070100,"IsLiked":false,"Tags":[]}]';
            
            //RootObject account = JsonConvert.DeserializeObject<RootObject>(json);

            return View();
        }
    }
}