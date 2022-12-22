using Microsoft.AspNetCore.Mvc;
using ViajeFacil.Dominio.EF;
using ViajeFacil.Poco;
using ViajeFacil.Service.Viagem;

namespace ViajeFacilApi.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [Route("api/viajefacil/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {
        private EventoService servico;

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        public EventoController(ViajeFacilContexto context) : base()
        {
            this.servico = new EventoService(context);
        }

        /// <summary>
        /// Lista todos os registros de Evento por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<EventoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<EventoPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Evento por chave Instituição.
        /// </summary>
        /// <param name="instituicaocod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorInstituicao/{instituicaocod:long}")]
        public ActionResult<List<EventoPoco>> GetByInstituicao(long instituicaocod)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(eve => eve.CodigoInstituicao == instituicaocod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Evento por chave Endereço.
        /// </summary>
        /// <param name="enderecocod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorEndereco/{enderecocod:long}")]
        public ActionResult<List<EventoPoco>> GetByEndereco(long enderecocod)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(eve => eve.CodigoEndereco == enderecocod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Evento por chave Usuário Responsável.
        /// </summary>
        /// <param name="usuariocod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorUsuarioResponsavel/{usuariocod:long}")]
        public ActionResult<List<EventoPoco>> GetByUsuarioResponsavel(long usuariocod)
        {
            try
            {
                List<EventoPoco> listaPoco = this.servico.Consultar(eve => eve.CodigoUsuarioResponsavel == usuariocod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Evento.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:long}")]
        public ActionResult<EventoPoco> GetById(long chave)
        {
            try
            {
                EventoPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado em Evento.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<EventoPoco> Post([FromBody] EventoPoco poco)
        {
            try
            {
                EventoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente em Evento.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<EventoPoco> Put([FromBody] EventoPoco poco)
        {
            try
            {
                EventoPoco novoPoco = this.servico.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:long}")]
        public ActionResult<EventoPoco> DeleteById(long chave)
        {
            try
            {
                EventoPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}