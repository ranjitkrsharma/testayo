using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectConvert.Conversion;

namespace ConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperatureController : ControllerBase
    {
        // GET api/temperature
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/temperature/5/UnitOfMeasure
        [HttpGet("{unitVal}/{UnitOfMeasure}")]
        public ActionResult<IEnumerable<string>> Get(double unitVal, string UnitOfMeasure)
        {// Enter with celsius, convert to fahrenheit. Enter with fahrenheit, convert to celsius
            double value = 0;
            if (UnitOfMeasure.Equals("celsius")) { value = ((unitVal * 9 / 5) + 32); }
            else if (UnitOfMeasure.Equals("fahrenheit")) { value = ((unitVal - 32) * 5 / 9); }
            return new string[] { unitVal.ToString(), value.ToString() };
        }

        // GET api/temperature/5/kg/lbs
        [HttpGet("{unitVal}/{UnitOfMeasureFrom}/{UnitOfMeasureTo}")]
        public ActionResult<IEnumerable<string>> Get(double unitVal, string UnitOfMeasureFrom, string UnitOfMeasureTo)
        {
            double lbValue;
            var convertor = new TemperatureConverter(UnitOfMeasureFrom, UnitOfMeasureTo);
            lbValue = convertor.LeftToRight(unitVal);

            return new string[] { unitVal.ToString() + " " + UnitOfMeasureFrom, lbValue.ToString() + " " + UnitOfMeasureTo };
        }

        // POST api/temperature
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/temperature/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/temperature/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
