using Microsoft.AspNetCore.Mvc;
using Catalogo.Models;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        private static List<Item> _items = new List<Item>
        {
            new Item
            {
                Id = 1,
                Nombre = "Lionel Messi",
                Posicion = "Delantero",
                PosicionCorta = "LW",
                Pais = "Argentina",
                PaisCodigo = "ARG",
                Bandera = "🇦🇷",
                Equipo = "Inter Miami",
                Goles = 838,
                Asistencias = 374,
                Partidos = 1067,
                Descripcion = "Considerado por muchos como el mejor jugador de todos los tiempos. 8 veces ganador del Balón de Oro y campeón del mundo con Argentina en Qatar 2022. Su habilidad con el balón, visión de juego y capacidad goleadora lo hacen único e irrepetible en la historia del fútbol.",
                FechaNacimiento = "24/06/1987",
                AlturaCm = 170,
                PesoKg = 72,
                NumeroCamiseta = 10,
                PieDominante = "Izquierdo",
                Clubes = "Barcelona, PSG, Inter Miami",
                FotoUrl = ""
            },
            new Item
            {
                Id = 2,
                Nombre = "Cristiano Ronaldo",
                Posicion = "Delantero",
                PosicionCorta = "ST",
                Pais = "Portugal",
                PaisCodigo = "POR",
                Bandera = "🇵🇹",
                Equipo = "Al Nassr",
                Goles = 925,
                Asistencias = 272,
                Partidos = 1237,
                Descripcion = "Máximo goleador en la historia del fútbol profesional. Ganador de 5 Balones de Oro, 5 Champions League y la Eurocopa 2016 con Portugal. Un atleta excepcional con una mentalidad competitiva sin igual y una capacidad de reinventarse década tras década.",
                FechaNacimiento = "05/02/1985",
                AlturaCm = 187,
                PesoKg = 84,
                NumeroCamiseta = 7,
                PieDominante = "Derecho",
                Clubes = "Sporting, Manchester United, Real Madrid, Juventus, Al Nassr",
                FotoUrl = ""
            },
            new Item
            {
                Id = 3,
                Nombre = "Neymar Jr",
                Posicion = "Extremo Izquierdo",
                PosicionCorta = "LW",
                Pais = "Brasil",
                PaisCodigo = "BRA",
                Bandera = "🇧🇷",
                Equipo = "Santos FC",
                Goles = 439,
                Asistencias = 267,
                Partidos = 716,
                Descripcion = "Uno de los jugadores más habilidosos y creativos del siglo XXI. Con su regate espectacular y capacidad de desequilibrio, formó parte de la temible MSN junto a Messi y Suárez en el Barcelona. Máximo goleador histórico de la selección brasileña.",
                FechaNacimiento = "05/02/1992",
                AlturaCm = 175,
                PesoKg = 68,
                NumeroCamiseta = 10,
                PieDominante = "Derecho",
                Clubes = "Santos, Barcelona, PSG, Al-Hilal, Santos",
                FotoUrl = ""
            },
            new Item
            {
                Id = 4,
                Nombre = "Kylian Mbappé",
                Posicion = "Delantero",
                PosicionCorta = "ST/RW",
                Pais = "Francia",
                PaisCodigo = "FRA",
                Bandera = "🇫🇷",
                Equipo = "Real Madrid",
                Goles = 312,
                Asistencias = 128,
                Partidos = 452,
                Descripcion = "La joven estrella más explosiva del fútbol mundial. Campeón del mundo con Francia en 2018 con apenas 19 años. Su velocidad demoledora, definición letal y madurez táctica lo perfilan como el heredero natural de Messi y Cristiano en la cima del fútbol.",
                FechaNacimiento = "20/12/1998",
                AlturaCm = 178,
                PesoKg = 73,
                NumeroCamiseta = 9,
                PieDominante = "Derecho",
                Clubes = "Monaco, PSG, Real Madrid",
                FotoUrl = ""
            },
            new Item
            {
                Id = 5,
                Nombre = "Mohamed Salah",
                Posicion = "Extremo Derecho",
                PosicionCorta = "RW",
                Pais = "Egipto",
                PaisCodigo = "EGY",
                Bandera = "🇪🇬",
                Equipo = "Liverpool",
                Goles = 326,
                Asistencias = 168,
                Partidos = 623,
                Descripcion = "El Rey Egipcio que conquistó la Premier League. Desde su llegada al Liverpool se convirtió en uno de los delanteros más letales del mundo. Ganador de la Champions League 2019 y múltiples veces máximo goleador de la Premier League.",
                FechaNacimiento = "15/06/1992",
                AlturaCm = 175,
                PesoKg = 71,
                NumeroCamiseta = 11,
                PieDominante = "Izquierdo",
                Clubes = "Basel, Chelsea, Fiorentina, Roma, Liverpool",
                FotoUrl = ""
            }
        };

        public IActionResult Index()
        {
            return View(_items);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Item item)
        {
            if (ModelState.IsValid)
            {
                item.Id = _items.Any() ? _items.Max(i => i.Id) + 1 : 1;
                _items.Add(item);
                return RedirectToAction("Index");
            }
            return View(item);
        }

        public IActionResult Detalle(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }
    }
}