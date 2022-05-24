using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.name == "DeadWall"){
            transform.position = new Vector3(-4,0.5f,4);
        }
        
    }

    void OnCollisionExit(Collision other) {
        if (other.gameObject.name == "Plane"){
            transform.position = new Vector3(-4,0.5f,4);
        }
    }
}
