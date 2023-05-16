using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IPartService
    {
        public string GetAllParts();
        public void UpdatePart(int partid, Part part);
        public void AddPart(Part part);
        public void RemovePart(int partid);
    }
}
