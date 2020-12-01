using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createTower : MonoBehaviour
{
    public GameObject cube;
    public float scaleX = 10f;
    public float scaleY = 10f;
    public float scaleZ = 10f;

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < scaleX; x++)
        {
            for (int y = 0; y < scaleY; y++)
            {
                for (int z = 0; z < scaleZ; z++)
                {
                    Vector3 offset = new Vector3(x, y, z);
                    GameObject clone = Instantiate(cube, cube.transform.position+offset, cube.transform.rotation); 
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
