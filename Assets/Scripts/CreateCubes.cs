using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCubes : MonoBehaviour
{
    public GameObject cube;
    public float upForce = 100f;
    Vector3 offset = new Vector3(0, 10);

    // Update is called once per frame
    void Update()
    {
        GameObject clone = Instantiate(cube, cube.transform.position+offset, cube.transform.rotation);
        Rigidbody rb = clone.GetComponent<Rigidbody>();
        Vector3 force = new Vector3(0, upForce, 0);
        rb.AddForce(force);

    }
}
