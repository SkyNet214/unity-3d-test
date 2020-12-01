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
    Vector3 offset = new Vector3((-scaleX+1) / 2, 0, (-scaleZ+1) / 2);
    
        for (int x = 0; x < scaleX; x++)
        {
            for (int y = 0; y < scaleY; y++)
            {
                for (int z = 0; z < scaleZ; z++)
                {
                    Vector3 scale = new Vector3(x, y, z);
                    GameObject clone = Instantiate(cube, offset+scale, cube.transform.rotation); 
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
