namespace _2071_Maximum_Number_of_Tasks_You_Can_Assign;

public class Solution {
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength) {
        Array.Sort(tasks);
        Array.Sort(workers);

        int left = 0, right = Math.Min(tasks.Length, workers.Length);
        int result = 0;

        while (left <= right) {
            int mid = (left + right) / 2;
            if (CanAssign(tasks, workers, pills, strength, mid)) {
                result = mid;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return result;
    }

    private bool CanAssign(int[] tasks, int[] workers, int pills, int strength, int k) {
        var taskQueue = new LinkedList<int>(tasks.Take(k));
        var usableWorkers = new LinkedList<int>(workers.Skip(workers.Length - k));

        int remainingPills = pills;

        while (taskQueue.Count > 0) {
            int hardestTask = taskQueue.Last.Value; 
            taskQueue.RemoveLast();

            if (usableWorkers.Last.Value >= hardestTask) {
                usableWorkers.RemoveLast(); // Рабочий справляется без таблетки
            } else {
                if (remainingPills == 0) return false;

                // Найти самого слабого рабочего, которого можно усилить и он справится
                var it = usableWorkers.First;
                while (it != null && it.Value + strength < hardestTask) {
                    it = it.Next;
                }

                if (it == null) return false;

                usableWorkers.Remove(it);
                remainingPills--;
            }
        }

        return true;
    }
}

public class Solution2
{
    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);
        Array.Sort(workers);

        var l = 0;
        var r = Math.Min(tasks.Length, workers.Length);

        while (l <= r)
        {
            var mid = (l + r) / 2;

            if (CanExecute(mid, tasks, workers, pills, strength))
            {
                l = mid + 1;
            }
            else
            {
                r = mid - 1;
            }
        }

        return r;
    }

    private static bool CanExecute(int k, int[] tasks, int[] workers, int pills, int strength)
    {
        // take k easiest tasks and k strongest workers
        // if task can be taken by strongest worker only by using pills, then assign weakest worker that can execute it with pill


        var ws = new LinkedList<int>();
        var currWorker = workers.Length - 1;

        for (var i = 0; i < k; i++)
        {
            while (currWorker >= workers.Length - k && workers[currWorker] + strength >= tasks[k - 1 - i])
            {
                ws.AddFirst(workers[currWorker]);
                currWorker--;
            }

            if (ws.Count == 0)
            {
                return false;
            }
            else if (ws.Last.Value >= tasks[k - 1 - i])
            {
                ws.RemoveLast();
            }
            else
            {
                // need to use pill
                if (pills == 0)
                {
                    return false;
                }

                pills--;
                ws.RemoveFirst();
            }
        }

        return true;
    }
}