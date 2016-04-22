using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projeto.Web.ServiceReferenceJogador;

namespace Projeto.Web.Controllers
{
    public class JogadorController : Controller
    {
        public ActionResult Cadastro()
        {
            return View();
        }

        public JsonResult Cadastrar(JogadorModelCadastro model)
        {
            try
            {
                using (JogadorServiceClient service = new JogadorServiceClient())
                {
                    service.Cadastrar(model);
                }

                return Json("Jogador cadastrado.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult CarregarTimes()
        {
            try
            {
                using (JogadorServiceClient service = new JogadorServiceClient())
                {
                    return Json(service.CarregarTimes());
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }
    }
}