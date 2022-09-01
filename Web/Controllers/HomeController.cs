using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models.Home;

namespace Web.Controllers
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

        public ActionResult Dados(string Nome, int Idade, int Cpf, string EstadoCivil, string NomeDeTratamento, int DocumentoDeIdentidade, string Sexo, string Escolaridade,
            string FormaçãoAcademica, DateTime ConclucaoMmesAno, string FormacaoAcademicaemAndamento, int CNPJdaEscola, DateTime Previsaodeconcluçao, int DDD, int Telefone, string Email )
        {
            DadosViewModel dadosViewModel = new DadosViewModel();

            dadosViewModel.Idade = Idade;
            dadosViewModel.Nome = Nome;
            dadosViewModel.EstadoCivil = EstadoCivil;
            dadosViewModel.Cpf = Cpf;
            dadosViewModel.EstadoCivil = EstadoCivil;
            dadosViewModel.NomeDeTratamento = NomeDeTratamento;
            dadosViewModel.DocumentoDeIdentidade = DocumentoDeIdentidade;
            dadosViewModel.Sexo = Sexo;
            dadosViewModel.Escolaridade = Escolaridade;
            dadosViewModel.FormaçãoAcademica = FormaçãoAcademica;
            dadosViewModel.ConclucaoMmesAno = ConclucaoMmesAno;
            dadosViewModel.FormacaoAcademicaemAndamento = FormacaoAcademicaemAndamento;
            dadosViewModel.CNPJdaEscola = CNPJdaEscola;
            dadosViewModel.Previsaodeconcluçao = Previsaodeconcluçao;
            dadosViewModel.DDD = DDD;
            dadosViewModel.Telefone = Telefone;
            dadosViewModel.Email = Email;
            

            return View(dadosViewModel);
        }
    }
}