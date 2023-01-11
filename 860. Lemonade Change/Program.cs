public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        PriorityQueue<int, int> q = new();

        Stack<int> s5 = new();
        Stack<int> s10 = new();

        foreach (int bill in bills)
        {
            switch (bill)
            {
                case 5:
                    s5.Push(5);
                    break;

                case 10:
                    if (s5.Any())
                    {
                        s5.Pop();
                        s10.Push(10);
                    }
                    else
                    {
                        return false;
                    }

                    break;

                case 20:
                    int temp = 15;
                    
                    if (s10.Any())
                    {
                        temp -= s10.Pop();
                    }

                    while (temp > 0)
                    {
                        if (s5.Any())
                        {
                            temp -= s5.Pop();
                        }
                        else
                        {
                            return false;
                        }
                    }

                    break;
            }
        }

        return true;
    }
}
