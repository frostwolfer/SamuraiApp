namespace SamuraiApp.Domain
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }

        //Navigational Properties:
        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
