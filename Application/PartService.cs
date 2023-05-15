using OnionCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PartService : IPartService
    {
        private readonly IEFPartRepository _EFPartRepository;
        public PartService(IEFPartRepository partRepository)
        {
            _EFPartRepository = partRepository;
        }




        public List<Part> GetAllParts()
        {
            return _EFPartRepository.GetAllParts();            
        }

        public void UpdatePart(int partid,Part part)
        {
            _EFPartRepository.UpdatePart(partid, part);
        }
    }
}
