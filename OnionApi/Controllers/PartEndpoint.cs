using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnionCore.Interfaces;
using OnionCore.Models;
namespace OnionApi.Controllers
{
    //[Authorize(Policy = "Bearer")]
    public class PartEndpoint : Controller
    {
        private readonly IPartService _partService;

        public PartEndpoint(IPartService partservice)
        {
            _partService = partservice;
        }
        [Authorize(Roles = "admin")]
        [HttpGet("api/parts/all")]
        public string GetAllParts()
        {
            var parts = _partService.GetAllParts();
            return parts;
        }

        [HttpPost("api/parts/add")]
        public void AddPart(Part part)
        {
            _partService.AddPart(part);
        }

        [Authorize(Roles = "admin")]
        [HttpDelete("api/parts/delete")]
        public void DeletePart(int partId)
        {
            _partService.RemovePart(partId);
        }
    }
}
