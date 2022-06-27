using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDisappearBehaviour : MonoBehaviour
{
    int BoolDecider;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlatformDisappearance());       
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    IEnumerator PlatformDisappearance()
    {
        while (true)
        {
            BoolDecider = Random.Range(1, 3);

            if (BoolDecider == 1)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = true;
                gameObject.GetComponent<BoxCollider>().enabled = true;
            }
            else
            {
                StartCoroutine(Titilar());

            }

            yield return new WaitForSeconds(5);
        }
       
    }

    IEnumerator Titilar(){
        for (int i = 0; i < 3; i++)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;

            yield return new WaitForSeconds(0.25f);

            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<BoxCollider>().enabled = true;

            yield return new WaitForSeconds(0.25f);

            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

}
