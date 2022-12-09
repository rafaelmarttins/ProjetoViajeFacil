using Microsoft.AspNetCore.Http;
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
    public class InstituicaoController : ControllerBase
    {
        private InstituicaoService servico;

        public InstituicaoController(ViajeFacilContexto context) : base()
        {
            this.servico = new InstituicaoService(context);
        }

        /// <summary>
        /// Lista todos os registros de Instituição por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<InstituicaoPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<InstituicaoPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        /// <summary>
        /// Listar todos os registros de Instituição por chave Endereço.
        /// </summary>
        /// <param name="enderecocod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorEndereco/{enderecocod:long}")]
        public ActionResult<List<InstituicaoPoco>> GetByEndereco(long enderecocod)
        {
            try
            {
                List<InstituicaoPoco> listaPoco = this.servico.Consultar(ins => ins.CodigoEndereco == enderecocod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Instituição.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:long}")]
        public ActionResult<InstituicaoPoco> GetById(long chave)
        {
            try
            {
                InstituicaoPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado em Instituição.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<InstituicaoPoco> Post([FromBody] InstituicaoPoco poco)
        {
            try
            {
                InstituicaoPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente em Instituição.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<InstituicaoPoco> Put([FromBody] InstituicaoPoco poco)
        {
            try
            {
                InstituicaoPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<InstituicaoPoco> DeleteById(long chave)
        {
            try
            {
                InstituicaoPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
