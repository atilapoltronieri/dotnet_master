using AMcom.Teste.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMcom.Teste.Service
{
    public class UbsDTO
    {
        //Nome, Endereco e Avaliacao
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Avaliacao { get; set; }

        public UbsDTO(Ubs pUbs)
        {
            Nome = pUbs.nom_estab;
            Endereco = string.Concat(pUbs.dsc_endereco, ", ", pUbs.dsc_bairro, ", ", pUbs.dsc_cidade);
            Avaliacao = pUbs.dsc_estrut_fisic_ambiencia;
        }
    }

}