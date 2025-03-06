public class RandomizedSet
{
    Dictionary<int, int> map;
    Random rand;
    List<int> list;
    public RandomizedSet()
    {
        map = new();
        rand = new();
        list = new();
    }

    public bool Insert(int val)
    {
        if (map.ContainsKey(val)) return false;
        list.Add(val);
        map.Add(val, list.Count - 1);
        return true;
    }

    public bool Remove(int val)
    {
        if (!map.ContainsKey(val)) return false;
        int lastVal = list[list.Count - 1];
        list[map[val]] = lastVal;
        map[lastVal] = map[val];
        list.RemoveAt(list.Count - 1);
        map.Remove(val);
        return true;
    }

    public int GetRandom() => list[rand.Next(0, list.Count)];

}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */