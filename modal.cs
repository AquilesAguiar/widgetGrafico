namespace widgetGrafico
{
    public class modal:janela
    {
        public int maxAlt {get; protected set; }
        public int maxLarg {get; protected set; }
        public int atualAlt {get; protected set; }
        public int atualLarg {get; protected set; }
    
        public override void AlteraTitular(string T){
            Titulo = T;
        }
    }
}