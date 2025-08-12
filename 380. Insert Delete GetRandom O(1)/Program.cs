using System.Collections.ObjectModel;

RandomizedSet obj = new RandomizedSet();

bool param_1 = obj.Insert(1);
bool param_2 = obj.Remove(2);

int param_3 = obj.GetRandom();

Console.Write($"1: {param_1}- 2: {param_2}");

public class RandomizedSet
{
    private readonly List<int> _store;
    private readonly Dictionary<int, int> _map;
    private readonly Random _random;

    public RandomizedSet()
    {
        _store = new List<int>();
        _map = new Dictionary<int, int>();
        _random = new Random();
    }

    public bool Insert(int val)
    {
        if (_map.ContainsKey(val))
            return false;

        _map[val] = _store.Count;
        _store.Add(val);

        return true;
    }

    public bool Remove(int val)
    {
        if (!_map.ContainsKey(val))
            return false;

        int index = _map[val];
        int lastElement = _store[^1];

        _store[index] = lastElement;
        _store.RemoveAt(_store.Count - 1);

        _map[lastElement] = index;
        _map.Remove(val);

        return true;
    }

    public int GetRandom() =>
        _store[_random.Next(_store.Count)];
}
