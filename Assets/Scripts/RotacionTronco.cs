using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionTronco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.eulerAngles.z >= 360)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        else
        {
            transform.Rotate(1, 0, 0);
        }
    }
}
