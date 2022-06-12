using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource source;
    public AudioSource source2;
    public AudioClip salto;
    public AudioClip theme;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySalto(){
        source.clip = salto;
        source.Play();
    }

    public void PlayTheme(){
        source2.clip = theme;
        source2.Play();
    }

}
