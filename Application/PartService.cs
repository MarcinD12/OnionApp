using OnionCore.Interfaces;
using OnionCore.Models;
using System.Text.Json;

namespace Application
{
    public class PartService : IPartService
    {
        private readonly IEFPartRepository _EFPartRepository;
        public PartService(IEFPartRepository partRepository)
        {
            _EFPartRepository = partRepository;
        }

        public string GetAllParts()
        {
            var allParts = _EFPartRepository.GetAllParts();
            return JsonSerializer.Serialize(allParts);
        }

        public void UpdatePart(int partid, Part part)
        {
            _EFPartRepository.UpdatePart(partid, part);
        }
        public void AddPart(Part part)
        {
            _EFPartRepository.AddPart(part);
        }

        public void RemovePart(int partid)
        {
            _EFPartRepository.DeletePart(partid);
        }
    }
}
