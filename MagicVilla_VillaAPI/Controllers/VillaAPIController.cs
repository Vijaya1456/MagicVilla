using Microsoft.AspNetCore.Mvc;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Data;
namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[comtroller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<VillaDTo>> GetVillas()
        {
          
            return Ok(VillaStore.villalist);
        }

        [HttpGet("{id:int}",Name ="GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        /* [ProducesResponseType(200, Type=typeof(VillaDTo)]
         [ProducesResponseType(404)]
         [ProducesResponseType(400)]*/
        public ActionResult<VillaDTo> GetVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villalist.FirstOrDefault(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDTo> CreateVilla([FromBody]VillaDTo villaDTo) {
        if(villaDTo == null)
            {
                return BadRequest();
            }
        if(villaDTo.Id>0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        villaDTo.Id = VillaStore.villalist.OrderByDescending(u => u.Id).FirstOrDefault().Id+1;
            VillaStore.villalist.Add(villaDTo);
            return CreatedAtRoute("GetVilla", new { id = villaDTo.Id }, villaDTo);
        }
    }
}
