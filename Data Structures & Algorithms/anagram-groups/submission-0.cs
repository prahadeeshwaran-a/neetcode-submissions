public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        var anagramDictionary =  new Dictionary<string, List<string>>();

        foreach (var s in strs){
            
            var charcs = s.ToCharArray();

            Array.Sort(charcs);

            var sortedKey = new String(charcs);

            if (!anagramDictionary.TryGetValue(sortedKey, out var list)){
                    list = new List<string>();
                    anagramDictionary[sortedKey] = list;
            }
            list.Add(s);
        }

        return anagramDictionary.Values.Cast<List<string>>().ToList();

    }
}
