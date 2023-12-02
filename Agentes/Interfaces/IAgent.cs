using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agentes.Interfaces
{
    public interface IAgent
    {
        double GetMedia(List<double> numbers);
        string GetStartCase(int x);
    }
}
