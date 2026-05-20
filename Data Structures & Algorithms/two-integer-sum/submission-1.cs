public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        int[] result = new int[2];

        Dictionary<int,int> values =  new Dictionary<int,int>();

        

        for (int i=0; i<nums.Length ; i++){
            int res =  target - nums[i];

            if (values.ContainsKey(res)){
                result[0] = values[res];
                result[1] = i;
            }

            if (!values.ContainsKey(nums[i])){
                values.Add(nums[i],i);
            }
        }

        return result;

    }
}
