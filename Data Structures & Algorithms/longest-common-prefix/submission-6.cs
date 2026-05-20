public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string result = "";
        int x = 0;

        int min = strs[0].Length;
        for (int i =1 ; i< strs.Length ; i++){
            if (strs[i].Length < min) min = strs[i].Length;
        }


        while(true){
            if (min == 0) break;
            
            var currentCharacter  = strs[0][x];
            var temp = 0;


            for (int i=0; i < strs.Length; i++){
                if(strs[i][x] == currentCharacter) temp++;
            }

            if (temp == strs.Length){
                result += currentCharacter;
            }
            
            else{
                break;
            }

            x++;

            if ( x >= min ) break;
        }
        
        return result;
    }
}