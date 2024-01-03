using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class applescript : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent <AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (IsVisible())
         {
            audioSource.Play();
         }
    }
    private bool IsVisible()
    { 
        return true;
    }
}
