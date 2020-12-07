using System;

namespace ConsoleApp1
{
    public class QueueItem
    {
        public QueueItem()
        {

        }

        public QueueItem(string procname, int time)
        {
            this.ProcName = procname;
            this.Time = time;
        }
        /// <summary>
        /// プロセス名
        /// </summary>
        public string ProcName { get; set; }
        /// <summary>
        /// 残り時間
        /// </summary>
        public int Time { get; set; }

    }
    class Program
    {
        static void Main()
        {
            var args = Console.ReadLine().Trim().Split(' ');
            var n = int.Parse(args[0]);
            var q = int.Parse(args[1]);
            var queue = new System.Collections.Generic.Queue<QueueItem>();

            for (int i = 0; i < n; i++)
            {
                var args2 = Console.ReadLine().Trim().Split(' ');
                queue.Enqueue(new QueueItem(args2[0], int.Parse(args2[1])));
            }

            // 経過時間
            var elapsedTime = 0;

            while (queue.Count > 0)
            {
                var item = queue.Dequeue();

                if (item.Time > q)
                {
                    elapsedTime += q;
                    item.Time = item.Time - q;
                    queue.Enqueue(item);
                }
                else
                {
                    elapsedTime += item.Time;
                    Console.WriteLine(item.ProcName + " " + elapsedTime);
                }
            }
        }
    }
}
