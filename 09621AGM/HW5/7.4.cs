using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _7
    {
        static void Main7(string[] args)
        {
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>()
        {
            { 1, new List<int> { 2, 3 } },
            { 2, new List<int> { 1, 4, 5 } },
            { 3, new List<int> { 1, 6 } },
            { 4, new List<int> { 2 } },
            { 5, new List<int> { 2, 6 } },
            { 6, new List<int> { 3, 5 } }
        };

            int startNode = 1;
            int targetNode = 6;

            PrintShortestPath(graph, startNode, targetNode);
        }

        public static void PrintShortestPath(Dictionary<int, List<int>> graph, int start, int target)
        {
            if (!graph.ContainsKey(start) || !graph.ContainsKey(target))
            {
                Console.WriteLine("Начальная или конечная вершина отсутствует в графе.");
                return;
            }

            Queue<int> queue = new Queue<int>();
            HashSet<int> visited = new HashSet<int>();
            Dictionary<int, int> parent = new Dictionary<int, int>();

            queue.Enqueue(start);
            visited.Add(start);
            parent[start] = -1;

            bool found = false;

            while (queue.Count > 0)
            {
                int current = queue.Dequeue();

                if (current == target)
                {
                    found = true;
                    break;
                }

                foreach (int neighbor in graph[current])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        parent[neighbor] = current;
                        queue.Enqueue(neighbor);
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"Путь из вершины {start} в вершину {target} не найден.");
                return;
            }

            List<int> path = new List<int>();
            int curr = target;
            while (curr != -1)
            {
                path.Add(curr);
                curr = parent[curr];
            }
            path.Reverse();

            Console.WriteLine($"Кратчайший путь от {start} до {target}: " + string.Join(" -> ", path));
        }
    }
}