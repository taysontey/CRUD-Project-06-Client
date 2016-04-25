using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
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

        [WebMethod]
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

        [WebMethod]
        public JsonResult Consultar()
        {
            try
            {
                using (JogadorServiceClient service = new JogadorServiceClient())
                {
                    return Json(service.Consultar());
                }
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [WebMethod]
        public JsonResult Editar(JogadorModelConsulta model)
        {
            try
            {
                var resultado = new JogadorModelConsulta();

                using (JogadorServiceClient service = new JogadorServiceClient())
                {
                    resultado = service.Editar(model.IdJogador);
                }
                return Json(resultado);
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [WebMethod]
        public JsonResult Atualizar(JogadorModelEdicao model)
        {
            try
            {
                using(JogadorServiceClient service = new JogadorServiceClient())
                {
                    service.Atualizar(model);
                }
                return Json("Jogador atualizado.");
            }
            catch (Exception e)
            {
                return Json(e.Message);
            }
        }

        [WebMethod]
        public JsonResult Excluir(JogadorModelConsulta model)
        {
            try
            {
                using (JogadorServiceClient service = new JogadorServiceClient())
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

        [WebMethod]
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