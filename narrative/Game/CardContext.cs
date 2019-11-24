namespace Narrative.Game
{
    public class CardContext : StoryContext
    {
        public Actor Self { get; set; }
        
        public Actor Other { get; set; }
        
        public Place Place { get; set; }
    }
}