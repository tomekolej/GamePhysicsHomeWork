using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gong : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;

    private void OnCollisionEnter(Collision collision)
    {
        //if (!AudioSource.isPlaying)
            AudioSource.Play();
    }
}
