using Microsoft.AspNetCore.Mvc;
using ProjectConvert.Conversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectConvert.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolumeController : ControllerBase
    {
        [HttpGet("{unitVal}/{UnitOfMeasureFrom}/{UnitOfMeasureTo}")]
        public ActionResult<IEnumerable<string>> Get(double unitVal, string UnitOfMeasureFrom, string UnitOfMeasureTo)
        {
            double lbValue;
            var convertor = new VolumeConverter(UnitOfMeasureFrom, UnitOfMeasureTo);
            lbValue = convertor.LeftToRight(unitVal);

            return new string[] { unitVal.ToString() + " " + UnitOfMeasureFrom, lbValue.ToString() + " " + UnitOfMeasureTo };
        }

        // GET: api/<VolumeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VolumeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VolumeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VolumeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VolumeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
