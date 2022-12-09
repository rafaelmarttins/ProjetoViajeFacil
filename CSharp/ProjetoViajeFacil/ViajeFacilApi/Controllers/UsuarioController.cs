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
    public class UsuarioController : ControllerBase
    {
        private UsuarioService servico;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public UsuarioController(ViajeFacilContexto context) : base()
        {
            this.servico = new UsuarioService(context);
        }

        /// <summary>
        /// Lista todos os registros de Usuário por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<UsuarioPoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<UsuarioPoco> lista = this.servico.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Usuário por chave Endereço.
        /// </summary>
        /// <param name="enderecocod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorEndereco/{enderecocod:long}")]
        public ActionResult<List<UsuarioPoco>> GetByEndereco(long enderecocod)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(usu => usu.CodigoEndereco == enderecocod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Usuário por chave Tipo Usuário.
        /// </summary>
        /// <param name="tipcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorTipoUsuario/{tipcod:long}")]
        public ActionResult<List<UsuarioPoco>> GetByTipoUsuario(long tipcod)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(usu => usu.CodigoTipoUsuario == tipcod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros de Usuário por chave Instituição.
        /// </summary>
        /// <param name="inscod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorInstituicao/{inscod:long}")]
        public ActionResult<List<UsuarioPoco>> GetByInstituicao(long inscod)
        {
            try
            {
                List<UsuarioPoco> listaPoco = this.servico.Consultar(usu => usu.CodigoInstituicao == inscod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Usuário.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:long}")]
        public ActionResult<UsuarioPoco> GetById(long chave)
        {
            try
            {
                UsuarioPoco poco = this.servico.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado em Usuário.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<UsuarioPoco> Post([FromBody] UsuarioPoco poco)
        {
            try
            {
                UsuarioPoco novoPoco = this.servico.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente em Usuário.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<UsuarioPoco> Put([FromBody] UsuarioPoco poco)
        {
            try
            {
                UsuarioPoco novoPoco = this.servico.Alterar(poco);
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
        public ActionResult<UsuarioPoco> DeleteById(long chave)
        {
            try
            {
                UsuarioPoco poco = this.servico.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
