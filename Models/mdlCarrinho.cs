using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Marcketplace.Models
{
    public class mdlCarrinho
    {
        public int id { get; set; }
        public DateTime dataPedido { get; set; }
        public int valorTotal { get; set; }
        public int statusPedido { get; set; }
        public string cliente { get; set; }
    }



}