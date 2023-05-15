using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore
{
    public interface IEFPartRepository
    {
        public List<Part> GetAllParts();
        public void UpdatePart(int partId, Part part);
    }
}
