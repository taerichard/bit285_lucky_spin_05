using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class RepoService
    {
        public IEnumerable<Spin> SpinRepository = new List<Spin>();

        public void AddSpins(Spin spin)
        {
            // changing to list first
             List<Spin> spinsContainer = SpinRepository.ToList();
            spinsContainer.Add(spin);
        }
    }
}
