using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float delay = 3f;
    public float explosionRadius = 5f;
    public float explosionForce = 1000f;
    bool isExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0 && !isExploded)
        {
            Explode();
        }
    }

    void Explode()
    {
        Collider[] nearObj = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider c in nearObj)
        {
            c.attachedRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            isExploded = true;
            Debug.Log("KhaaBoom!");
        }

    }
}
