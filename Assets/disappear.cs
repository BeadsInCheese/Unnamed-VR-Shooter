using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ManageGame.Instance.plng) {
            Destroy(this.transform.gameObject, 1f);
        }
    }
}