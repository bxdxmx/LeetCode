var s = new Solution();

var list = new List<IList<int>>();
list.Add(new List<int> { 1 });
list.Add(new List<int> { 2 });
list.Add(new List<int> { 3 });
list.Add(new List<int> {  });

s.CanVisitAllRooms(list);

public class Solution
{
    /*
      There are n rooms labeled from 0 to n - 1 and all the rooms are locked except for room 0. Your goal is to visit all the rooms. However, you cannot enter a locked room without having its key.
      When you visit a room, you may find a set of distinct keys in it. Each key has a number on it, denoting which room it unlocks, and you can take all of them with you to unlock the other rooms.
      Given an array rooms where rooms[i] is the set of keys that you can obtain if you visited room i, return true if you can visit all the rooms, or false otherwise.
     */

    /*
     * roomの順番は順不同でOK
     * 
     */
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var keyUsed = new HashSet<int>();
        var s = new Stack<int>();
        s.Push(0);

        while (s.Any())
        {
            var key = s.Pop();
            keyUsed.Add(key);

            foreach (var keyGot in rooms[key])
            {
                if (!keyUsed.Contains(keyGot))
                {
                    s.Push(keyGot);
                }
            }
        }

        return keyUsed.Count == rooms.Count;
    }

    // 間違い。先頭から見る場合はこれでOK
    public bool CanVisitAllRooms2(IList<IList<int>> rooms)
    {
        var s = new HashSet<int>() { 0 };

        for (int i = 0; i < rooms.Count; i++)
        {
            if (!s.Contains(i))
            {
                return false;
            }

            foreach (var key in rooms[i])
            {
                s.Add(key);
            }
        }

        return true;
    }

}
