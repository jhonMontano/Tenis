// See https://aka.ms/new-console-template for more information
using tenis;

Jugador jugador_1 = new Jugador();
jugador_1.nombre="nadal";
jugador_1.nacionalidad="español";
jugador_1.manoHabil=true;


Jugador jugador_2 = new Jugador();

jugador_2.nombre="federer";
jugador_2.nacionalidad="suizo";
jugador_2.manoHabil=false;

Torneo torneo = new Torneo("Roland Garros",2500000);

torneo.AddJugador(jugador_1);
torneo.AddJugador(jugador_2);

torneo.jugarPartido();
