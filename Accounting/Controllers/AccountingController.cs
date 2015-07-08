using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using System.Globalization;
using System.Net.Http;
using System.Net;


namespace Accounting.Controllers
{
    public class AccountingController : Controller
    {
        // GET: api/Accounting
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Accounting/5
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new
            {
                
                Reservation = new
                {
                    ReservationId = ""
                }
                
            }, JsonRequestBehavior.AllowGet);            
        }

        // POST: api/Accounting
        [HttpPost]
        public JsonResult Post(JsonResult value)
        {
            return Json(new
            {

                Reservation = new
                {
                    ReservationId = ""
                }

            }, JsonRequestBehavior.AllowGet); 
        }
    }
}
