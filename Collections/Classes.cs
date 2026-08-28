namespace Skills2;

public class CollectionsSkills
{
    /// Count the words in a string.
    ///
    /// This method doesn't handle punctuation so 'hello!' and 'hello'
    /// are two different words. It also doesn't handle capitalization so
    /// 'Hello' and 'hello' are two different words as well.
    public static Dictionary<string, int> CountWords(string text)
    {
        var wordCount = new Dictionary<string, int>();

        // Get all words in the text and put them into an array. 
        string[] words = text.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        // If the word is already in the dictionary, increment the count.
        // Else, add the word into the dictionary. 
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            } else
            {
                wordCount.Add(word, 1);
            }
        }

        return wordCount;
    }

    // Do not modify the code between the "==========" lines.
    // ==========
    public class Melon(string type, double price)
    {
        public string Type { get; set; } = type;
        public double Price { get; set; } = price;
    }
    static readonly Melon[] _melons = [
        new Melon("honeydew", 2.5),
        new Melon("cantaloupe", 2.5),
        new Melon("watermelon", 2.95),
        new Melon("musk", 3.25),
        new Melon("crenshaw", 3.25),
        new Melon("christmas", 14.25)
    ];
    // ==========

    /// Return a list with the **names** of melons being sold at the given price.
    ///
    /// This will return the names of melons from `_melons`. `_melons` is a list of
    /// `Melon` objects. If there are no melons being sold at the given price it returns
    /// an empty list.
    public static List<string> GetMelonTypesAtPrice(double price)
    {
        var melonsAtPrice = new List<string>();

        foreach (var melon in _melons)
        {
            if (melon.Price == price)
            {
                melonsAtPrice.Add(melon.Type);
            }
        }
        
        return melonsAtPrice;
    }

    // Do not modify the code between the "==========" lines.
    // ==========
    static readonly Dictionary<string, string> _engToPirate = new()
    {
        {"sir", "matey"},
        {"hotel", "fleabag inn"},
        {"student", "swabbie"},
        {"man", "matey"},
        {"professor", "foul blaggart"},
        {"restaurant", "galley"},
        {"your", "yer"},
        {"excuse", "arr"},
        {"students", "swabbies"},
        {"are", "be"},
        {"restroom", "head"},
        {"my", "me"},
        {"is", "be"},
    };
    // ==========

    /// Return a phrase in pirate talk.
    ///
    /// Given an English phrase, use `_engToPirate` to translate words to pirate talk.
    /// Words that aren't listed in `_engToPirate` should not be translated and should
    /// pass through unchanged.
    ///
    /// The given phrase will be normalized so it will never contain punctuation and will
    /// only consist of lowercased letters.
    public static string TranslateToPirate(string englishText)
    {
        string[] englishWords = englishText.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        string translatedToPirate = "";

        // Check to see if the words are in _engToPirate. 
        // If they are, append the words to the result. 
        foreach (var word in englishWords)
        {
            if (_engToPirate.ContainsKey(word))
            {
                translatedToPirate += _engToPirate[word];
            }
            else
            {
                translatedToPirate += word;
            }
            translatedToPirate += " ";
        }

        // Remove the extra space at the end. 
        if (translatedToPirate.Length > 0)
        {
            translatedToPirate = translatedToPirate.Substring(0, translatedToPirate.Length - 1);
        }

        return translatedToPirate;
    }

    /// Return a sequence of words arranged according to the rules below.
    ///
    /// The sequence starts with the first word in the given list. The next word will
    /// start with the last letter of the preceding word. For example, these are all valid
    /// sequences of words:
    ///
    ///     zoo, octos, sour, racket, cute, etcetera, antsy, yak, karat
    ///
    /// Sometimes you'll get a word where there are multiple candidates for the next
    /// word. For example, if our list of words contains:
    ///
    ///     noon, naan, nun
    ///
    /// ...then the first word in the sequence is 'noon':
    ///
    ///     noon
    ///
    /// ...the next word should be the *first* word that starts with 'n'. So, even though
    /// 'naan' and 'nun' both start with 'n', the next word should be 'naan' because
    /// 'naan' appears before 'nun'. The final sequence of words will be:
    ///
    ///     noon, naan, nun
    ///
    /// The sequence will continue in this fashion until it runs out of words or it can't
    /// find words that'll fit the pattern.
    public static List<string> CreateWordChain(List<string> words)
    {
        var wordChain = new List<string> { words[0] };
        words.RemoveAt(0);

        while (words.Count > 0)
        {
            var lastLetter = wordChain[^1].Last();
            var matchIndex = -1;

            // Find the first word that starts with the required letter. 
            for (var j = 0; j < words.Count; j++)
            {
                if (words[j].First() == lastLetter)
                {
                    matchIndex = j;
                    break;
                }
            }

            // The chain can't grow any further because no word starts with the required letter.
            if (matchIndex == -1)
            {
                break;
            }

            wordChain.Add(words[matchIndex]);
            words.RemoveAt(matchIndex);
        }

        return wordChain;
    }
}
