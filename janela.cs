namespace widgetGrafico
{
    public abstract class janela
    {
        public bool BotaoFechar {get; protected set;}
        public bool BotaoMax {get; protected set;}
        public bool BotaoMin {get; protected set;}
        public string Titulo {get; protected set;}
        public int PosX {get; protected set;}
        public int PosY {get; protected set;}

        public abstract void MoverJanela(int X,int Y);
        
    }
}