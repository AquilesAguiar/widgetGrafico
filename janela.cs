namespace widgetGrafico
{
    public class janela
    {
        public boolean BotaoFechar {get; private set;}
        public boolean BotaoMax {get; private set;}
        public boolean BotaoMin {get; private set;}
        public string Titulo {get; private set;}]
        public int PosX {get; private set;}
        public int PosY {get; private set;}

        public void MoverJanela(int X,int Y){
            PosX = X;
            Posy = Y;
        }
        
        public void AlteraTitular(string T){
            Titulo = T;
        }
    }
}