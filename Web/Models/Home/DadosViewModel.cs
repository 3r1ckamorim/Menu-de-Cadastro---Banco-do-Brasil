using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models.Home
{
    public class DadosViewModel
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public int Cpf { get; set; }

        public string EstadoCivil { get; set; }

        public string NomeDeTratamento { get; set; }

        public int DocumentoDeIdentidade { get; set; }

        public string Sexo { get; set; }

        public string Escolaridade { get; set; }

        public string FormaçãoAcademica { get; set; }

        public DateTime ConclucaoMmesAno { get; set; }

        public string FormacaoAcademicaemAndamento { get; set; }

        public int CNPJdaEscola { get; set; }

        public DateTime Previsaodeconcluçao { get; set; }

        public int DDD { get; set; }

        public int Telefone { get; set; }

        public string Email { get; set; }
    }

}