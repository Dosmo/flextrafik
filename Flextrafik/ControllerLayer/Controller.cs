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
        DatabaseFacade dbf = new DatabaseFacade();
        public List<Firma> GetFirma()
        {
            List<Firma> firmList = dbf.GetFirma();
            return firmList;

            //ViewLayer; af sadri
        }
    }
}
