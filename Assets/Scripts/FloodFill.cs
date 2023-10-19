using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class FloodFill : MonoBehaviour
{
    public Tilemap tileMap;
    public TileBase tb;
    private Queue<Vector3Int> frontier = new Queue<Vector3Int>();
    public Vector3Int startingPoint;
    public set reached = new set();
    public Dictionary<Vector3Int, Vector3Int> came_from = new Dictionary<Vector3Int, Vector3Int>();
    
    private void Update()
    
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ExpandTilemap();
        }
    }
    public void ExpandTilemap()
    {
        Vector3Int start = startingPoint;
        frontier.Enqueue(start);
        reached.Add(start);
        while (frontier.Count > 0)
        {
            var current = frontier.Dequeue();
            List<Vector3Int> neighbors = GetNeighbors(current);
            foreach (Vector3Int neighbor in neighbors)
            {
                if (!reached.Set.Contains(neighbor) && tileMap.GetTile(neighbor) != null)
                {
                    if (neighbors != null)
                    {
                        frontier.Enqueue(neighbor);
                        reached.Add(neighbor);
                        tileMap.SetTile(neighbor, tb);
                    }
                }
            }
        }
        List<Vector3Int> GetNeighbors(Vector3Int current)
        {
            List<Vector3Int> neighbors = new List<Vector3Int>();
            neighbors.Add(new Vector3Int(current.x - 1, current.y, current.z));
            neighbors.Add(new Vector3Int(current.x + 1, current.y, current.z));
            neighbors.Add(new Vector3Int(current.x, current.y - 1, current.z));
            neighbors.Add(new Vector3Int(current.x, current.y + 1, current.z));

            return neighbors;
        }
    }
}
