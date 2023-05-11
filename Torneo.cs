namespace tenis;
class Torneo
{
    public string nombre;
    public int premio;

    private Random random;

    public IJugador[] jugadores = new IJugador [2];

    public Torneo(string nombre, int premio)
    {
        this.nombre = nombre;
        this.premio = premio;
        this.random=new Random();
    }

public void AddJugador( IJugador jugador){
    if(this.jugadores[0]!=null){
this.jugadores[1]=jugador;
    }else{
this.jugadores[0]=jugador;
    }
}

public int jugarSet(){
    return this.random.Next(0,3);
}

public void  jugarPartido(){

    int player1=0;
    int player2=0;

    for(int i=0;i<5;i++){
        if(this.jugarSet()==0){
            player1++;
        }else{
            player2++;
        }
    }

    if(player1>player2){
        Console.WriteLine("Ganador es el jugador: "+this.jugadores[1].nombre);
    }else{
         Console.WriteLine("Ganador es el jugador: "+this.jugadores[0].nombre);
    }
}
}