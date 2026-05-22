public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var elements =  new Dictionary<int,int>();

        for (int i = 0 ; i<nums.Length ; i++){
           elements[nums[i]] = elements.GetValueOrDefault(nums[i], 0) + 1;
            
        }
       

        var queue = new PriorityQueue<int, int> ();
        foreach( var x in elements){
            queue.Enqueue(x.Key,x.Value);

            if (queue.Count > k) {
                queue.Dequeue();
            }
        }

        int[] result = new int[k];

        for(int i=0 ;i<k;i++){
            result[i] = queue.Dequeue();
        }

        return result;
    }

    
}
