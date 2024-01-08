using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    float counter = Mathf.PI/2;
    float increment = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += increment * 50 * Time.deltaTime;
        float r=Mathf.Sin(counter);
        //Debug.Log(r);
        transform.Rotate(0, r/Mathf.Abs(r)*10*Time.deltaTime, 0);
    }
}
