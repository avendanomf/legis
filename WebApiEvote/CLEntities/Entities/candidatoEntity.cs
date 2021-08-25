using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEntities.Entities
{
    public class candidatoEntity
    {
        public int id_candidato { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string fecha_nacimiento { get; set; }
        public string correo_electronico { get; set; }
        public string tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string foto { get; set; }
    }
}
