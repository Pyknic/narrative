using System;
using Narrative.Game;

namespace Narrative.Language
{
    public class EnglishLanguage : ILanguage
    {
        public string BoyGirl(Gender gender)
        {
            switch (gender)
            {
                case Gender.MALE:    return "boy";
                case Gender.FEMALE:  return "girl";
                case Gender.NEUTRAL: return "kid";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public string HeShe(Gender gender)
        {
            switch (gender)
            {
                case Gender.MALE:    return "he";
                case Gender.FEMALE:  return "she";
                case Gender.NEUTRAL: return "they";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public string HimHer(Gender gender)
        {
            switch (gender)
            {
                case Gender.MALE:    return "him";
                case Gender.FEMALE:  return "her";
                case Gender.NEUTRAL: return "their";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public string HisHer(Gender gender)
        {
            switch (gender)
            {
                case Gender.MALE:    return "his";
                case Gender.FEMALE:  return "her";
                case Gender.NEUTRAL: return "their";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public string The(string noun)
        {
            return "the " + noun;
        }
    }
}