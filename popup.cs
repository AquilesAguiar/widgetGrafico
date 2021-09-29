namespace widgetGrafico
{
    public class popup:janela
    {
        public bool BotaoOk {get; private set;}
        public bool BotaoCancel {get; private set;} 
        public override void MoverJanela(int X,int Y){
            PosX = X;
            PosY = Y;
        }
    }
}