namespace Locadora.Controle
{
    internal class Automovel
    {
        public int auto_id { get; set; }
        public string auto_nome { get; set; }
        public string auto_ano_fab { get; set; }
        public string auto_cor { get; set; }
        public double auto_km { get; set; }
        public double auto_valor_d { get; set; }
        public string auto_status { get; set; }

        public int marca_id { get; set; }

        public int modelo_id { get; set; }
    }
}
