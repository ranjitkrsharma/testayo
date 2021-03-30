﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConverterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthController : ControllerBase
    {
        // GET api/temperature
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/length/5/UnitOfMeasure
        [HttpGet("{unitVal}/{UnitOfMeasure}")]
        public ActionResult<IEnumerable<string>> Get(double unitVal, string UnitOfMeasure)
        {// Enter with km, convert to mile. Enter with mile, convert to km
            double value = 0;
            if (UnitOfMeasure.Equals("km")) { value = (unitVal * 0.62); }
            else if (UnitOfMeasure.Equals("mile")) { value = (unitVal / 0.62); }
            return new string[] { unitVal.ToString(), value.ToString() };
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
