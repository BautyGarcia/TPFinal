using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivo1 : MonoBehaviour
{
    bool goUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (goUp){
            transform.Translate(0.025f,0,0);

            if (transform.position.y >= 3){
                goUp = false;
            }

        } else {
            transform.Translate(-0.025f,0,0);

            if (transform.position.y <= -1){
                goUp = true;
            }

        }

    }


}
