namespace Narrative.Game
{
    public class Actor : StoryNode
    {
        public Gender Gender { get; set; }

        public string HeShe => language.HeShe(Gender);
        
        public string HimHer => language.HimHer(Gender);
        
        public string HisHer => language.HisHer(Gender);
        
        public string BoyGirl => language.BoyGirl(Gender);
    }
}