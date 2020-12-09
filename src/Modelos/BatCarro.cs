using Batcaverna.Interfaces;

namespace Batcaverna.Modelos
{
    public class BatCarro : IEntidadeCadastravel
    {
        public long Id { get; set; }
        public bool ResistenteÀCorte { get; set; }
        public bool ResistenteÀBalas { get; set; }
        public string CorPrincipal { get; set; }
        public bool RodasResistenteÀBalas { get; set; }
        public bool RodasResistenteÀCorte { get; set; }        
    }
}
