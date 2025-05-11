using AutoMapper;
using Microsoft.AspNetCore.Components.Forms.Mapping;
using Microsoft.AspNetCore.Mvc;
using retotecnico_bcp.Data;
using retotecnico_bcp.Model;
using retotecnico_bcp.Request;
using retotecnico_bcp.Response;

namespace retotecnico_bcp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoCambioController : ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;

        //private readonly IMappe _mapper;
        public TipoCambioController(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("GetMonedas")]
        public IActionResult GetMonedas()
        {
            List<Moneda> lista = null;
            if (_dbContext.Monedas != null)
            {
                lista = _dbContext.Monedas.ToList();
            }

            return Ok(lista);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetTipoCambio([FromBody] TipoCambioRequest tipoCambioRequest)
        {
            TipoCambio tipoCambio = _dbContext.TipoCambios.Where(s => s.monedaDestino.inIdMoneda == tipoCambioRequest.inIdmonedaDestino && s.monedaOrigen.inIdMoneda == tipoCambioRequest.inIdmonedaOrigen).First();

            Moneda monedaOrigen = _dbContext.Monedas.Where(s => s.inIdMoneda == tipoCambioRequest.inIdmonedaOrigen).First();
            Moneda monedaDestino = _dbContext.Monedas.Where(s => s.inIdMoneda == tipoCambioRequest.inIdmonedaDestino).First();

            tipoCambio.monedaOrigen = monedaOrigen;
            tipoCambio.monedaDestino = monedaDestino;

            TipoCambioResponse tipoCambioResponse = _mapper.Map<TipoCambioResponse>(tipoCambio);
            tipoCambioResponse.dcMonto = tipoCambioRequest.dcMonto;
            tipoCambioResponse.dcMontoConTipoCambio = tipoCambioRequest.dcMonto * tipoCambio.dcTipoCambio;

            return Ok(tipoCambioResponse);
        }

        [HttpPost]
        [Route("")]
        public IActionResult SaveTipoCambio([FromBody] TipoCambio tipoCambio)
        {
            Moneda monedaOrigen = _dbContext.Monedas.Where(s => s.inIdMoneda == tipoCambio.monedaOrigen.inIdMoneda).First();
            Moneda monedaDestino = _dbContext.Monedas.Where(s => s.inIdMoneda == tipoCambio.monedaDestino.inIdMoneda).First();
            tipoCambio.monedaOrigen = monedaOrigen;
            tipoCambio.monedaDestino = monedaDestino;
            TipoCambio tipoCambioResponse = _dbContext.TipoCambios.Add(tipoCambio).Entity;
            _dbContext.SaveChanges();
            return Ok(tipoCambioResponse);
        }
    }
}
