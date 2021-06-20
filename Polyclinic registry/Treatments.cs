using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic_registry
{
    static public class Treatments
    {
        static public List<Treatment> treatments { get; set; }
        static Treatments()
        {
            treatments = new List<Treatment>();
        }

        static public void AddNewTreatment(Treatment tr)
        {
            treatments.Add(tr);
        }

        static public void RemoveTreatment(int ind)
        {
            treatments.RemoveAt(ind);
        }
    }
}
