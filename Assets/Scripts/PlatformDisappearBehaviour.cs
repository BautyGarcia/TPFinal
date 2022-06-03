using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDisappearBehaviour : MonoBehaviour
{
    public bool isOn;
    int BoolDecider;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(PlatformDisappearance());
        BoolDecider = Random.Range(1, 3);

        if (BoolDecider == 1) {
            isOn = true;
        }
        else
        {
            isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    IEnumerator PlatformDisappearance()
    {
        while (true)
        {
            if (isOn)
            {
                gameObject.SetActive(false);
                isOn = false;
                yield return new WaitForSeconds(3);
            }
            else
            {
                gameObject.SetActive(true);
                isOn = true;
                yield return new WaitForSeconds(3);
            }

        }
    }
}
