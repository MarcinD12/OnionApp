using OnionCore.Models;

namespace OnionCore.Interfaces
{
    public interface IEFPartRepository
    {
        public List<Part> GetAllParts();
        public void UpdatePart(int partId, Part part);
        public void AddPart(Part part);
        public void DeletePart(int partId);
    }
}
