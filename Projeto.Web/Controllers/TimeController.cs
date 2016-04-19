using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using Projeto.Web.ServiceReferenceTime;

namespace Projeto.Web.Controllers
{
    public class TimeController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Consulta()
        {
            return View();
        }

        [WebMethod]
        public JsonResult Cadastrar(TimeModelCadastro model)
        {
            try
            {
                using(TimeServiceClient service = new TimeServiceClient())
                {
                    service.Cadastrar(model);
                }

                return Json("Time cadastrado.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [WebMethod]
        public JsonResult Consultar()
        {
            try
            {
                using(TimeServiceClient service = new TimeServiceClient())
                {
                    return Json(service.Consultar());
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}