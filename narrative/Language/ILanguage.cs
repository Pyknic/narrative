using Narrative.Game;

namespace Narrative.Language
{
    public interface ILanguage
    {
        string BoyGirl(Gender gender);
        
        string HeShe(Gender gender);

        string HimHer(Gender gender);

        string HisHer(Gender gender);

        string The(string noun);
    }
}