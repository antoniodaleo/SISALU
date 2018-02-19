using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISALU.Model
{
    public class Curso
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int CargaHoraria { get; set; }
        public DateTime DataCad { get; set; }

    }
}
