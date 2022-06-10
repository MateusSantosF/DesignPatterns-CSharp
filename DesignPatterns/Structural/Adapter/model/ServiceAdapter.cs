using DesignPatterns.Structural.Adapter.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter.model
{
    public class ServiceAdapter : IService
    {
        private LegacyService LegacyService;

        public ServiceAdapter(LegacyService legacyService)
        {
            LegacyService = legacyService;
        }
        public void DoAnythingCurrent()
        {
            Console.WriteLine($" I adapt something{{{LegacyService.DoAnythingLegacy()}}}");
        }
    }
}
