using System;
using Narrative.Language;

namespace Narrative.Game
{
    [Serializable()]
    public class StoryNode
    {
        protected ILanguage language;
        
        public uint Id { get; set; }
        
        public string Name { get; set; }

        public string TheName => language.The(Name);
        
        protected StoryNode()
        {
            Id = (uint) new Random().Next();
            language = new EnglishLanguage();
        }
    }
}