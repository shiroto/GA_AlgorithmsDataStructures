using System.Collections.Generic;
using System.Linq;

namespace Graphs
{
    /// <summary>
    /// Implement the A* algorithm.
    /// Use <see cref="NodeHelper.EstimateDistance(Node, Node)"/> for estimated and real distances.
    /// </summary>
    public static class AStar
    {
        public static Node[] GeneratePath(Node start, Node goal)
        {
            Node currentNode;
            List<Node> open = new List<Node>();
            List<Node> closed = new List<Node>();
            open.Add(start);
            start.EstimatedCost = NodeHelper.EstimateDistance(start, goal);

            while (open.Any())
            {
                currentNode = GetLowestTotalCost(open);
                closed.Add(currentNode);
                open.Remove(currentNode);
                if (currentNode.Equals(goal)) // found shortest path
                {
                    return GetPath(currentNode);
                }
                foreach (Node neighbor in currentNode.GetNeighbors())
                {
                    float newCost = currentNode.Cost + NodeHelper.EstimateDistance(neighbor, currentNode);
                    if (open.Contains(neighbor) && neighbor.Cost <= newCost) // already have a shorter path
                    {
                        continue;
                    }
                    else if (closed.Contains(neighbor))
                    {
                        if (neighbor.Cost <= newCost)
                        {
                            continue;
                        }
                        else
                        {
                            closed.Remove(neighbor);
                        }
                    }
                    open.Add(neighbor);
                    neighbor.EstimatedCost = NodeHelper.EstimateDistance(neighbor, goal);
                    neighbor.Cost = newCost;
                    neighbor.Predecessor = currentNode;
                }
            }

            // no path found
            return null;
        }

        private static Node GetLowestTotalCost(List<Node> list)
        {
            float min = float.MaxValue;
            Node smallest = default;
            foreach (Node node in list)
            {
                if (node.Cost + node.EstimatedCost < min)
                {
                    min = node.Cost;
                    smallest = node;
                }
            }
            return smallest;
        }

        private static Node[] GetPath(Node goalNode)
        {
            Node current = goalNode;
            List<Node> path = new List<Node>();
            while (current != null)
            {
                path.Add(current);
                current = current.Predecessor;
            }
            path.Reverse();
            return path.ToArray();
        }
    }
}