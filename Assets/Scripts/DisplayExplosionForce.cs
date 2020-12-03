using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayExplosionForce : MonoBehaviour
{
    public Text text;
    public GameObject grenadePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = grenadePrefab.GetComponent<Explosion>().explosionForce.ToString();
    }
}
