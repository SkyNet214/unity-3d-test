using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenate : MonoBehaviour
{
    public GameObject GrenatePrefab;
    public Camera PlayerCamera;
    public float throwForce = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            _throw();
        }
    }

    void _throw()
    {
        GameObject grenate = Instantiate(GrenatePrefab, new Vector3(0,100,0), transform.rotation);
        //grenate.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce);
    }
}
