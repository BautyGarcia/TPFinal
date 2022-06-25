using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float movementSpeed;

    float posX;
    float posY;
    float posZ;

    public GameObject cubo;
    GameObject clon;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, movementSpeed);

        if (gameObject.transform.position.z >= -32f){
            Destroy(gameObject, 0);

            posX = gameObject.transform.position.x;
            posY = gameObject.transform.position.y;
            posZ = gameObject.transform.position.z;

            for (int i = 0; i < 5; i++)
            {
                clon = Instantiate(cubo);
                clon.transform.position = new Vector3(posX, posY, posZ);
                Destroy(clon, 2);
            }
        }
    }
}
