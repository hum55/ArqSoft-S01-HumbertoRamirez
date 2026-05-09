namespace Catalogo.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Posicion { get; set; } = "";
        public string PosicionCorta { get; set; } = "";
        public string Pais { get; set; } = "";
        public string PaisCodigo { get; set; } = "";
        public string Bandera { get; set; } = "";
        public string Equipo { get; set; } = "";
        public int Goles { get; set; }
        public int Asistencias { get; set; }
        public int Partidos { get; set; }
        public string Descripcion { get; set; } = "";
        public string FechaNacimiento { get; set; } = "";
        public int AlturaCm { get; set; }
        public int PesoKg { get; set; }
        public int NumeroCamiseta { get; set; }
        public string PieDominante { get; set; } = "";
        public string Clubes { get; set; } = "";
        public string FotoUrl { get; set; } = "";
    }
}