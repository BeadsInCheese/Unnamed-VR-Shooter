using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ManageGame.Instance.plng)
        {
            this.gameObject.SetActive(true);

        }
        else
        {
            this.gameObject.SetActive(false);
            
        }
    }
}
