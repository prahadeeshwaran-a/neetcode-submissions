public class MyHashSet {

    private List<int> mySet; 
    public MyHashSet() {
        mySet = new List<int>();
    }
    
    public void Add(int key) {
        if (!this.Contains(key)){
            mySet.Add(key);
        }
    }
    
    public void Remove(int key) {
        mySet.Remove(key);
    }
    
    public bool Contains(int key) {
        return mySet.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */