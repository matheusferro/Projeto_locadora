using System.IO;

namespace Locadora.Controle
{
    internal class Login
    {
        public int id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
        public string tipo { get; set; }
        public MemoryStream ms { get; set; }
    }
}
