using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    public bool isRewinding = false;

    List<Vector3> positions;
    List<Quaternion> rotations;
    void Start()
    {
        positions = new List<Vector3>();
        rotations = new List<Quaternion>();
    }

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            StartRewind();
        }
        if (Input.GetKeyUp("z"))
        {
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        } else
        {
            Record();
        }
    }

    void Rewind()
    {
        transform.position = positions[0];
        transform.rotation = rotations[0];
        positions.RemoveAt(0);
        rotations.RemoveAt(0);
    }

    void Record()
    {
        positions.Insert(0, transform.position);
        rotations.Insert(0, transform.rotation);
    }

    void StartRewind ()
    {
        GetComponent<Rigidbody>().isKinematic = true;
        isRewinding = true;
    }
    
    void StopRewind ()
    {
        GetComponent<Rigidbody>().isKinematic = false;
        isRewinding = false;
    }
}
