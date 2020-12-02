using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowGrenade : MonoBehaviour
{
    public GameObject grenadePrefab;
    public float throwForce = 10f;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _throw();
        }
    }

    void _throw()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position + transform.forward, transform.rotation);
        grenade.GetComponent<Rigidbody>().AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
