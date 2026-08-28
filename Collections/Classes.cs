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
        return new Dictionary<string, int>();
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
        return new List<string>();
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
        return "";
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
        return new List<string>();
    }
}
