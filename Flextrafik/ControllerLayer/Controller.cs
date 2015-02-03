using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using HelperLayer;

namespace ControllerLayer
{
    public class Controller
    {
        public List<Firma> GetFirma()
        {
            List<Firma> firmaListe = new List<Firma>();

            DatabaseFacade.GetFirma();

            return firmaListe;

            ViewLayer
        }
    }
}
