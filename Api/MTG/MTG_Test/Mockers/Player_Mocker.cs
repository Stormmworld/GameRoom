using MTG.Model;

namespace MTG_Test.Mockers
{
    public static class Player_Mocker
    {
        public static Player Mock()
        {
            return new Player()
            {
                Name = "Mock Player"
            };
        }
    }
}
