using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set : MonoBehaviour
{
    //public List<T>
    public List<Vector3Int> Set;


  public void Add(Vector3Int current)
    {
        if (!Set.Contains(current))
        {
            Debug.Log("Agregue un neighbor " + current);
            Set.Add(current);
        }
    }



}
