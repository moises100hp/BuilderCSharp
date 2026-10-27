using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hamburguer
    {
        public string TipoPao { get; set; }
        public string TipoCarne { get; set; }
        public bool TemBacon { get; set; }
        public bool TemBatataPalha { get; set; }
        public bool TemQueijo { get; set; }
        public bool TemSalada { get; set; }
        public string getDescricao()
        {
            return @$"Hamburguer com pão {TipoPao} e carne: {TipoCarne} Bacon: {TemBacon}, Salada: {TemSalada}, Batata Palha: {TemBatataPalha},Queijo: {TemQueijo}";
        }
    }
}
