using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void start() {
        ManageGame.Instance.startGame();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
