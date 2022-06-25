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
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.025f, transform.position.z);
            

            if (transform.position.y >= 3){
                goUp = false;
                
            }

        } else {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.025f, transform.position.z);
           

            if (transform.position.y <= -1){
                goUp = true;
                
            }

        }

    }



}
