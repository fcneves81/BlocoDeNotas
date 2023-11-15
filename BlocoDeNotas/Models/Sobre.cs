using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocoDeNotas.Models
{
    public class Sobre
    {
        public string Titulo { get; set; }

        public string Versao { get; set; }

        public string Descricao { get; set; }

        public string Mensagem { get; set;}

        public string MaisInformacoesUrl { get; set;}

        public Sobre()
        {
            this.Titulo = AppInfo.Name;
            this.Versao = AppInfo.VersionString;
            this.Descricao = "Desenvolvido em .NET MAUI por Fernando Camargo, o objetivo deste aplicativo é ser o seu bloco de notas pessoal.";
            this.Mensagem = "Obrigado por seu apoio e utilização!";
            this.MaisInformacoesUrl = "https://curriculo-fernando-camargo.web.app/";
        }
    }
}
