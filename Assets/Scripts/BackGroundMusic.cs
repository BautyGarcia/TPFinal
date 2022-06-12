using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public AudioManager miAM;
    // Start is called before the first frame update
    void Start()
    {
        miAM.PlayTheme();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
