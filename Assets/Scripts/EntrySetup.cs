using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntrySetup : MonoBehaviour
{
    public Text score;
    public Text playerName;
    public Text placement;
    // Start is called before the first frame update
    public void SetUp(string placement, string name, string score) {
        this.score.text = score;
        this.playerName.text = name;
        this.placement.text = placement;

    
    }
}
