using System.Linq;
using UnityEngine;

namespace Graphs
{
    public class AStarMono : MonoBehaviour
    {
        private Node currentStart, currentGoal;

        [SerializeField]
        private LineRenderer lineRenderer;

        private Node[] path;

        [SerializeField]
        private Node start, goal;

        private void ResetAllNodes()
        {
            Node[] nodes = GameObject.FindObjectsOfType<Node>();
            foreach (Node node in nodes)
            {
                node.Predecessor = null;
                node.Cost = 0;
                node.EstimatedCost = 0;
            }
        }

        private void Update()
        {
            if (currentStart == start && currentGoal == goal)
            {
                return;
            }
            currentStart = start;
            currentGoal = goal;
            ResetAllNodes();
            path = AStar.GeneratePath(start, goal);
            if (path != null)
            {
                Vector3[] positions = path.Select(n => n.transform.position).ToArray();
                lineRenderer.positionCount = positions.Length;
                lineRenderer.SetPositions(positions);
            }
        }
    }
}