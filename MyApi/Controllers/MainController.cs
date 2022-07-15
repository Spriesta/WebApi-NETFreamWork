using MyApi.Models;
using MyApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Results;
using System.Web.Http;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using System.Web.Mvc;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;
using RouteAttribute = System.Web.Mvc.RouteAttribute;

namespace MyApi.Controllers
{
    public class MainController : ApiController
    {
        // GET api/values/5       
        [HttpGet]
        public JsonResult GetList()
        {
            MainRepository rep = new MainRepository();  // repo bağlantısı
            List<StudentReturnListModel> rList = rep.getList();

            return new JsonResult() { Data = rList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }

        // GET api/values/5       
        [HttpPost]
        public JsonResult userDelete(string id)
        {
            MainRepository rep = new MainRepository();  // repo bağlantısı
            string rList = rep.userDelete(id);

            return new JsonResult() { Data = rList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public JsonResult userUpdate(string id, string name, string age, string from, string gender)
        {
            MainRepository rep = new MainRepository();  // repo bağlantısı
            string rList = rep.userUpdate(id, name, age, from, gender);

            return new JsonResult() { Data = rList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

    }
}









/*
        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
*/


/*Controller
 MainRepository rep = new MainRepository(); // repo bağlantısı

        [HttpPost]
        public JsonResult getList(int id)
        {
           
            MainRepository rep = new MainRepository();
            List<StudentReturnListModel> rList = rep.getList(id);

            return Json(rList, JsonRequestBehavior.AllowGet);
        }
 */




/*repo
  
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //bağlantı açık kapalı kontrolü yap        
        public List<StudentReturnListModel> getList(int id)
        {
            string sql = $@"
                         SELECT * FROM student WHERE id = '{id}'
                            ";
            List<StudentReturnListModel> res = connection.Query<StudentReturnListModel>(sql).ToList();

            return res;
        }
        */


