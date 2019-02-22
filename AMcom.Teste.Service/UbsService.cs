using AMcom.Teste.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMcom.Teste.Service
{
    public class UbsService
    {
        public static List<UbsDTO> GetNearestUbs(double pLatitude, double pLongitude)
        {
            CoordinatesService coordinatesService = new CoordinatesService(pLatitude, pLongitude);
            List<Ubs> ubsList = Ubs.GetAllUbs();
            List<UbsDTO> ubsDTOList = new List<UbsDTO>();

            foreach (var ubs in ubsList.AsParallel())
            {
                ubs.distance = coordinatesService.DistanceTo(new CoordinatesService(ubs.vlr_latitude, ubs.vlr_longitude), UnitOfLength.Kilometers);
            }

            ubsList = ubsList.OrderBy(x => x.distance).Take(5).ToList().OrderBy(x => x.desempenho_enum).ToList();

            foreach (var ubs in ubsList)
            {
                ubsDTOList.Add(new UbsDTO(ubs));
            }

            return ubsDTOList;
        }
    }
}