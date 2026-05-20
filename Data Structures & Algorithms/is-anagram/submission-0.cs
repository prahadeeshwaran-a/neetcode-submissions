public class Solution {
    public bool IsAnagram(string s, string t) {

        int[] frequency = new int[256] ;

        for (int i=0 ; i<s.Length ; i++){
            frequency[s[i]] += 1;
        }

        for (int i=0 ; i< t.Length ; i++){
            frequency[t[i]] -= 1;
        }

        foreach ( var x in frequency){
            if (x != 0) return false;
        }
        
        return true;
    }
}
