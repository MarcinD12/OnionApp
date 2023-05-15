using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionCore
{
    public interface IPartService
    {
        public List<Part> GetAllParts();
        public void UpdatePart(int partid, Part part);
    }
}
