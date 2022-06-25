using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion1Disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform spawn;
    public GameObject spawnPoint;
    GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        spawnPoint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ExampleCoroutine()
    {
        while (true)
        {
            clon = Instantiate(bala, spawn.transform.position, spawn.transform.rotation);
            yield return new WaitForSeconds(3);         
        }
    }

}
