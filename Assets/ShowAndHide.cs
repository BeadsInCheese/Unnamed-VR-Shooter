using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAndHide : MonoBehaviour
{
    public GameObject button;
    public GameObject text;
    public GameObject button2;
    public GameObject text2;
    public GameObject Input;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!ManageGame.Instance.plng)
        {
            button.SetActive(true);
            text.SetActive(true);
            button2.SetActive(true);
            text2.SetActive(true);
            Input.SetActive(true);
        }
        else {
            button.SetActive(false);
            text.SetActive(false);
            button2.SetActive(false);
            text2.SetActive(false);
            Input.SetActive(false);
        }
    }
}
