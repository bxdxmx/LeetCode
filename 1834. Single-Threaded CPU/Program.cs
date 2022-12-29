var s = new Solution();

var tasks = new int[][]
{
    new int[]{19,13 },
    new int[]{16,9 },
    new int[]{21,10 },
    new int[]{32,25 },
    new int[]{37,4 },
    new int[]{49,24 },
    new int[]{2,15 },
    new int[]{38,41 },
    new int[]{37,34 },
    new int[]{33,6 },
    new int[]{45,4 },
    new int[]{18,18 },
    new int[]{46,39 },
    new int[]{12,24 }
};

s.GetOrder(tasks);

public class Solution
{
    private class MyTask
    {
        public int Index { get; set; }
        public int EnqueueTime { get; set; }
        public int ProcessingTime { get; set; }

        public MyTask(int index, int enqueueTime, int processingTime)
        {
            Index = index;
            EnqueueTime = enqueueTime;
            ProcessingTime = processingTime;
        }
    }

    public int[] GetOrder(int[][] tasks)
    {
        PriorityQueue<MyTask, int> inQ = new();
        PriorityQueue<MyTask, MyTask> processQ = new(Comparer<MyTask>.Create((a, b) =>
                a.ProcessingTime != b.ProcessingTime
                ? a.ProcessingTime - b.ProcessingTime
                : a.Index - b.Index));

        for (int i = 0; i < tasks.Length; i++)
        {
            MyTask task = new(i, tasks[i][0], tasks[i][1]);
            inQ.Enqueue(task, task.EnqueueTime);
        }

        List<int> res = new();
        int counter = 1;
        MyTask? processingTask = null;

        while (inQ.Count > 0 || processQ.Count > 0)
        {
            if (inQ.Count > 0 && inQ.Peek().EnqueueTime <= counter && processingTask == null)
            {
                var inTask = inQ.Dequeue();
                processQ.Enqueue(inTask, inTask);
            }
            else
            {
                if (processQ.Count > 0)
                {
                    processingTask ??= processQ.Peek();

                    counter += processingTask.ProcessingTime;

                    processQ.Dequeue();
                    res.Add(processingTask.Index);
                    processingTask = null;
                }
                else
                {
                    if (inQ.Count > 0)
                    {
                        counter = inQ.Peek().EnqueueTime;
                    }
                }
            }
        }

        return res.ToArray();
    }
}
