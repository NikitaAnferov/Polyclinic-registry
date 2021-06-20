using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic_registry
{
    public interface IOperate
    {
        void AddPatient(Patient pa);
        void RemovePatient(int ind);
    }
}
