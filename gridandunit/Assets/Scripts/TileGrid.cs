using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGrid : MonoBehaviour
{

    public int xsize;
    public int ysize;
    public float offset;
    public GridTile tile;



    // Use this for initialization
    void Start()
    {

        //    gridSize = new Vector3[(xSize + 1) * (ySize + 1)];
        //    for (int i = 0, z = 0; z <= ySize; z++)
        //    {
        //        for (int x = 0; x <= xSize; x++, i++)
        //        {
        //            gridSize[i] = new Vector3(x, 0, z);
        //        }
        //    }
        //    for (int i = 0; i < gridSize.Length; i++)
        //    {
        //        Instantiate(tile, gridSize[i], Quaternion.identity);
        //    }
        //}

        float Xoffset = 0;
        
        for (int i = 0; i < xsize; i++)
        {
            float Yoffset = 0;
            //zelfde loop maar dan voor y met daarin instantiate            
            for (int y = 0; y < ysize; y++)
            {
                Instantiate(tile, new Vector3(Xoffset, 0, Yoffset), Quaternion.identity);
                Yoffset += offset;
            }
            
            Xoffset += offset;
        }
    }
}
