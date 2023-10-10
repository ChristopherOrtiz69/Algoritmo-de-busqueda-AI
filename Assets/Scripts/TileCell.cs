using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileCell : MonoBehaviour
{
   

    /*void MousePosition()
    {
        Vector3 mouse = Input.mousePosition;

    }*/
    void TaskOnClick()
    {
        {
            Vector2 screenPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            GridLayout gridLayout = transform.parent.GetComponentInParent<GridLayout>();
            //Meter coordenadas del mouse aqui 
            Vector3Int cellPosition = gridLayout.WorldToCell(screenPosition);
            transform.position = gridLayout.CellToWorld(cellPosition);

            if (Input.GetMouseButtonDown(0))
                Debug.Log("Coordenadas" + cellPosition);
        }
    }
    void Update()
    {
        TaskOnClick();
    }
   
}