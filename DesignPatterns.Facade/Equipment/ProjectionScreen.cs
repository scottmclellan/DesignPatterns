namespace DesignPatterns.Facade
{
    public class ProjectionScreen : EquipmentBase, IScreen,IEquipment
    {
        public ProjectionScreen(string name="Theatre Screen") : base(name)
        {
        }

        public void Down()
        {
            Output("Coming down");
        }

        public void Up()
        {
            Output("Going up");
        }
    }
}