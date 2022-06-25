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
        if (transform.eulerAngles.x >= 90){
            transform.eulerAngles = new Vector3(0, 180, 90);
        } else {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x + 1, transform.eulerAngles.y, transform.eulerAngles.z);
        }
        
    }
}
