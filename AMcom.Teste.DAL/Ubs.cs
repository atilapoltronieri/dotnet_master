using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AMcom.Teste.DAL
{
    public class Ubs
    {
        public double vlr_latitude { get; set; }
        public double vlr_longitude { get; set; }
        public string nom_estab { get; set; }
        public string dsc_endereco { get; set; }
        public string dsc_bairro { get; set; }
        public string dsc_cidade { get; set; }
        public string dsc_estrut_fisic_ambiencia { get; set; }
        public DesempenhoEnum desempenho_enum { get; set; }
        public double distance { get; set; }

        public Ubs()
        {

        }

        public Ubs(double pVlrLatitude, double pVlrLongitude, string pNomEstab, string pDscEndereco, string pDscBairro, string pDscCidade, string pDscEstrut, DesempenhoEnum pDesempenhoEnum)
        {
            vlr_latitude = pVlrLatitude;
            vlr_longitude = pVlrLongitude;
            nom_estab = pNomEstab;
            dsc_endereco = pDscEndereco;
            dsc_bairro = pDscBairro;
            dsc_cidade = pDscCidade;
            dsc_estrut_fisic_ambiencia = pDscEstrut;
            desempenho_enum = pDesempenhoEnum;
        }

        public static List<Ubs> GetAllUbs()
        {
            return UbsRepository.LoadUbs();
        }

        public enum DesempenhoEnum
        {
            [Description("Desempenho muito acima da média")]
            MuitoAcimaMedia = 0,
            [Description("Desempenho acima da média")]
            AcimaMedia = 1,
            [Description("Desempenho mediano ou  um pouco abaixo da média")]
            MedioBaixo = 2,
        }
    }
}