namespace widgetGrafico
{
    public class janela
    {
        public bool BotaoFechar {get; protected set;}
        public bool BotaoMax {get; protected set;}
        public bool BotaoMin {get; protected set;}
        public string Titulo {get; protected set;}
        public int PosX {get; protected set;}
        public int PosY {get; protected set;}

        public void MoverJanela(int X,int Y){
            PosX = X;
            PosY = Y;
        }
        
        public virtual void AlteraTitular(string T){
            Titulo = T;
        }
    }
}