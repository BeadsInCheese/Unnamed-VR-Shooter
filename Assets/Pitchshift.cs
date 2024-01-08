using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pitchshift : MonoBehaviour
{
    public AudioSource aani;
    // Start is called before the first frame update
    void Start()
    {
        aani.pitch = Random.Range(0.6f,1f);
    }


}
