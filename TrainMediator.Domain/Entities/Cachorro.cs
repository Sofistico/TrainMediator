using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainMediator.Domain.Enums;

namespace TrainMediator.Domain.Entities
{
    public class Cachorro : BaseEntity
    {
        public Raca Raca { get; set; }
        public Porte Porte { get; set; }
        public int TamanhoCm { get; set; }
        public string Nome { get; set; }
        public List<string> Adjetivos { get; set; }

        public Cachorro()
        {

        }

        public Cachorro(Raca raca, Porte porte, int tamanhoCm, string nome, List<string> adjetivos)
        {
            Raca = raca;
            Porte = porte;
            TamanhoCm = tamanhoCm;
            Nome = nome;
            Adjetivos = adjetivos;
        }
    }
}
