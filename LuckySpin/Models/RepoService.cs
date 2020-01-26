using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LuckySpin.Models
{
    public class RepoService
    {
        private List<Spin> _spinRepository = new List<Spin>();
        

        public IEnumerable<Spin> SpinRepository
        {
            get
            {
                return _spinRepository;
            }
        }      
 
        public void AddSpins(Spin spin)
        {
            _spinRepository.Add(spin);
        }
    }
}
