namespace DesignPatterns.Behavioral_Patterns.TemplateMethod
{
    public class ColdVeggiePizza : PanFood
    {
        public ColdVeggiePizza()
        {
            base.RequiresBaking = false;
        }
    }
}
