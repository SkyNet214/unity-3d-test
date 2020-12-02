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
        //this.GetComponent<Rigidbody>().useGravity = false;
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

    void OnCollisionEnter(Collision collision)
    {
        Explode();
    }

    void Explode()
    {
        Collider[] nearObj = Physics.OverlapSphere(transform.position, explosionRadius);
        if (nearObj.Length > 0)
        {
            foreach (Collider c in nearObj)
            {
                if (c.tag !=  "Player")
                {
                    Rigidbody rb = c.GetComponent<Rigidbody>();
                    if (rb != null)
                    {
                        rb.AddExplosionForce(explosionForce, this.transform.position, explosionRadius);
                    }
                }

            }
            Destroy(this.gameObject);
            Debug.Log("KhaaBoom!");
        }
    }
}
