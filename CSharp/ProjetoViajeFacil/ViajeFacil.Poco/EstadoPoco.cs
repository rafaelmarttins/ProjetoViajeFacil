using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajeFacil.Poco
{
    public class EstadoPoco
    {
        public long CodigoEstado { get; set; }
        public string Nome { get; set; } = null!;
        public long? CodigoUf { get; set; }
        public string SiglaUf { get; set; } = null!;
        public long CodigoRegiao { get; set; }

        public EstadoPoco()
        { }
    }
}
