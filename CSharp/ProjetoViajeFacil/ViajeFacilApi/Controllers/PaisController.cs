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
    public class PaisController : ControllerBase
    {
        private PaisService servico;

        /// <summary>
        ///
        /// </summary>
        /// <param name="context"></param>
        public PaisController(ViajeFacilContexto context) : base()
        {
            this.servico = new PaisService(context);
        }

        /// <summary>
        /// Lista todos os registros de País por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<PaisPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<PaisPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de País.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:long}")]
        public ActionResult<PaisPoco> GetById(long chave)
        {
            try
            {
                PaisPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado em País.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<PaisPoco> Post([FromBody] PaisPoco poco)
        {
            try
            {
                PaisPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente em País.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<PaisPoco> Put([FromBody] PaisPoco poco)
        {
            try
            {
                PaisPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<PaisPoco> DeleteById(long chave)
        {
            try
            {
                PaisPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}