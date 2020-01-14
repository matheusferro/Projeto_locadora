using System;

namespace Locadora.Controle
{
    internal class Locacao
    {
        public int locacao_id { get; set; }
        public string locacao_tipo { get; set; }
        public double locacao_valor { get; set; }
        public DateTime locacao_dt_inicio { get; set; }
        public DateTime locacao_dt_fim { get; set; }

        public int funcionario { get; set; }
        public int cliente { get; set; }
        public int automovel { get; set; }

    }
}
