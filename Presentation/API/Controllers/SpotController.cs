using Application.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpotController : ControllerBase
    {
        private readonly ISpotRepository _spotRepository;
        private readonly  IInvoiceRepository _invoiceRepository;

        public SpotController(ISpotRepository spotRepository, IInvoiceRepository invoiceRepository)
        {
            _spotRepository = spotRepository;
            _invoiceRepository = invoiceRepository;
        }


        [HttpGet("GetAllSpotItems")]
        public IActionResult GetAllSpotItems()
        {
            var model = _spotRepository.GetAllSpots();
            return Ok(model);


        }
        [HttpGet("GetPeriod")]
        public IActionResult GetPeriod(int ay ,int yil)
        {
            var model2 = _spotRepository.GetByPeriod(ay, yil);
            return Ok(model2);

        }
        [HttpGet("GetMonth")]
        public IActionResult GetMonth(int ay, int yil)
        {
            var model3 = _spotRepository.GetByMonth(ay, yil);
            return Ok(model3);

        }
        [HttpGet("GetInvoice")]
        public IActionResult GetInvoice(int ay, int yil, int kurum_id)
        {
            var model4 = _invoiceRepository.CreateInvoices( kurum_id, ay, yil);
            return Ok(model4);


        }


    }

}
