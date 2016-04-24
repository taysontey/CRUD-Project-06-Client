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

        public ActionResult Consulta()
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

        public JsonResult Consultar()
        {
            try
            {
                using(JogadorServiceClient service = new JogadorServiceClient())
                {
                    return Json(service.Consultar());
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        public JsonResult Excluir(JogadorModelConsulta model)
        {
            try
            {
                using(JogadorServiceClient service = new JogadorServiceClient())
                {
                    service.Excluir(model.IdJogador);
                }

                return Json("Jogador excluído.");
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