// Death First Search - Episode 1 - solution in C#


using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]); // Total number of nodes
        int L = int.Parse(input[1]); // Number of links
        int E = int.Parse(input[2]); // Number of exit gateways

        List<int>[] graph = new List<int>[N];
        for (int i = 0; i < N; i++)
        {
            graph[i] = new List<int>();
        }

        // Read links
        for (int i = 0; i < L; i++)
        {
            input = Console.ReadLine().Split();
            int N1 = int.Parse(input[0]);
            int N2 = int.Parse(input[1]);
            graph[N1].Add(N2);
            graph[N2].Add(N1);
        }

        // Read exit gateways
        int[] exitGateways = new int[E];
        for (int i = 0; i < E; i++)
        {
            exitGateways[i] = int.Parse(Console.ReadLine());
        }

        // Game loop
        while (true)
        {
            int SI = int.Parse(Console.ReadLine()); // Position of the Bobnet agent

            // Check if the agent and gateway are adjacent
            bool isAgentNextToGateway = false;
            foreach (int gateway in exitGateways)
            {
                if (graph[SI].Contains(gateway))
                {
                    isAgentNextToGateway = true;
                    Console.WriteLine($"{SI} {gateway}"); // Sever link between agent and gateway
                    break;
                }
            }

            if (!isAgentNextToGateway)
            {
                // Find the closest node not linked to a gateway
                int closestNode = FindClosestNode(graph, exitGateways, SI);
                Console.WriteLine($"{closestNode} {exitGateways[0]}"); // Sever link between gateway and closest node
            }
        }
    }

    static int FindClosestNode(List<int>[] graph, int[] exitGateways, int startNode)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[graph.Length];

        queue.Enqueue(startNode);
        visited[startNode] = true;

        while (queue.Count > 0)
        {
            int currentNode = queue.Dequeue();

            foreach (int neighbor in graph[currentNode])
            {
                if (!visited[neighbor] && !exitGateways.Contains(neighbor))
                {
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                    return neighbor; // Return the first non-gateway neighbor found
                }
            }
        }

        // This should not happen in the given constraints
        return -1;
    }
}



while (true) {
  var SI = +readline();
  var r1, r2 = SI;

  // Check if agent neighbours are close to a gate
  var neighbours = graph[SI];
  var gate = neighbours.find(n => gates.indexOf(n) !== -1);

  if (gate !== undefined) {
    r1 = gate;
  } else if (neighbours.length === 2) {

    // If the agent has two options, cut the one with more neighbours
    if (graph[neighbours[0]].length < graph[neighbours[1]].length) {
      r1 = neighbours[1];
    } else {
      r1 = neighbours[0];
    }
  } else {

    // Create a list of gate neighbours having 3 neighbours themselves
    var gateNeighbours = [];
    for (var g = 0; g < gates.length; g++) {
      var gn = graph[gates[g]];

      for (var n = 0; n < gn.length; n++) {
        if (graph[gn[n]].length === 3) {
          gateNeighbours.push(gn[n]);
        }
      }
    }

    // Take the first gate neighbour for the moment, could be improved
    r1 = gateNeighbours[0];

    // Cut on the ring to another neighbour
    r2 = graph[r1].find(n => gateNeighbours.indexOf(n) !== -1);

    if (r2 === undefined) {
      r1 = neighbours[0];
      r2 = SI;
    }
  }

  graph[r1] = graph[r1].filter(x => x !== r2);
  graph[r2] = graph[r2].filter(x => x !== r1);

  print(r1 + ' ' + r2);
}