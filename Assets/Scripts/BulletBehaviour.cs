using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, movementSpeed, 0);

        if (gameObject.transform.position.z >= -32){
            Destroy(gameObject,0);
        }
    }
}
