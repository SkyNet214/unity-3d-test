using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeBody : MonoBehaviour
{
    public bool isRewinding = false;

    List<Vector3> positions;

    void Start()
    {
        positions = new List<Vector3>();
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
        positions.RemoveAt(0);
    }

    void Record()
    {
        positions.Insert(0, transform.position);
    }

    void StartRewind ()
    {
        isRewinding = true;
    }
    
    void StopRewind ()
    {
        isRewinding = false;
    }
}
