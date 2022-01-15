using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCoWebAppHalil.Model;

namespace UnluCoWebAppHalil
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private static List<FlightTicket> FlightList = new List<FlightTicket>()
        {
            new FlightTicket("Halil","Bolat",1,"TK0008",default,true),
            new FlightTicket("Enes","Turhan",2,"TK0007",default,false),
            new FlightTicket("Aynur","Bolat",3,"TK0009",default,true)
        };
        [HttpGet]
        public List<FlightTicket> GetFlightTickets()
        {
            return FlightList;
        }
        [HttpGet("{id}")]
        public ActionResult GetFlightTicket(int id)
        {
            var ticket = FlightList.Where(x => x.Id == id).FirstOrDefault();
            if(ticket == null)
            {
                return BadRequest(ticket);
            }
            return Ok(ticket);
        }
        [HttpPost]
        public ActionResult AddFlightTicket([FromBody]FlightTicket newflight)
        {
            FlightList.Add(newflight);
            return Ok();
        } 
        [HttpDelete]
        public ActionResult DeleteFlightTicket(int id)
        {
            var ticket=FlightList.Where(x=>x.Id==id).FirstOrDefault();
            FlightList.Remove(ticket);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult UpdateFlightTicket(int id,[FromBody]FlightTicket flightTicket)
        {
            var ticket = FlightList.Any(x => x.Id == id);
            var ticket2 =FlightList.Where(x => x.Id == id).FirstOrDefault();
            if (ticket)
            {
                ticket2.Id = flightTicket.Id;
                ticket2.Name = flightTicket.Name;
                ticket2.Surname = flightTicket.Surname;
                ticket2.FlightCode = flightTicket.FlightCode;
                ticket2.FlightDate = flightTicket.FlightDate;
                return Ok();
            }
            return BadRequest();
        }
        [HttpPatch] 
        public ActionResult PatchFlightTicket(int id, [FromBody] FlightTicket flightTicket)
        {
            var ticket = FlightList.Any(x => x.Id == id);
            var ticket2 = FlightList.Where(x => x.Id == id).FirstOrDefault();
            if (ticket)
            {
                ticket2.Id = flightTicket.Id;
                return Ok();
            }
            return BadRequest();
        }
    }
   
}
