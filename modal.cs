namespace widgetGrafico
{
    public class modal:janela,IDimensionavel
    {
        public int maxAlt {get; protected set; }
        public int maxLarg {get; protected set; }
        public int atualAlt {get; protected set; }
        public int atualLarg {get; protected set; }
    
        public void AlteraTitular(string T){
            Titulo = T;
        }
        public override void MoverJanela(int X,int Y){
            PosX = X;
            PosY = Y;
        }

        public void fullScreen(){}
        public void setLargura(int larg){}
        public void setAltura(int alt){}
    }
}