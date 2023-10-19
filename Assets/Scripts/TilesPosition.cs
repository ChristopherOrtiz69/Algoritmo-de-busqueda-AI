using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TilesPosition : MonoBehaviour
{
    public Tilemap tM;
    public TileBase Tb1;
    public TileBase Tb2;
    public FloodFill floodFill;

    void Update()
    {
        var cam = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        var _location = tM.WorldToCell(cam);
        _location.z = 0;
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Inicio Seleccionado " + "<color=#00ff00ff>" + _location + "</color>");
            tM.SetTile(_location, Tb1);
            floodFill.startingPoint = _location;
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Objetivo Seleccionado " + "<color=red>" + _location + "</color>");
            tM.SetTile(_location, Tb2);
        }
    }
}

