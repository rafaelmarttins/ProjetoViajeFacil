using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class CidadePoco
    {
        public long CodigoCidade { get; set; }
        public string Nome { get; set; } = null!;
        public long CodigoIbge7 { get; set; }
        public string SiglaUf { get; set; } = null!;
        public long CodigoEstado { get; set; }

        public CidadePoco()
        { }
    }
}
