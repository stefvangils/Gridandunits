using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour {

    public int xSize;
    public int ySize;
    public float offset;
    public GridTile tile;
    public Vector3[] gridSize;


    // Use this for initialization
    void Start () {
        //for (int i = 0; i < 10; i++)
        //{
        //    Instantiate(tile, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        //}
        gridSize = new Vector3[(xSize + 1) * (ySize + 1)];
        for (int i = 0, z = 0; z <= ySize; z++)
        {
            for (int x = 0; x <= xSize; x++, i++)
            {
                gridSize[i] = new Vector3(x, 0, z);
            }
        }
        for (int i = 0; i < gridSize.Length; i++)
        {
            Instantiate(tile, gridSize[i], Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
