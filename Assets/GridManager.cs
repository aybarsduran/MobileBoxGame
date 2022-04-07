using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public float x_Space, y_Space;
    
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 60; i++)
        {
            Vector2 position;
            position = new Vector3(x_Space * (i), (y_Space *i));
            Instantiate(prefab, position, Quaternion.identity);
           

        }

    }
}
