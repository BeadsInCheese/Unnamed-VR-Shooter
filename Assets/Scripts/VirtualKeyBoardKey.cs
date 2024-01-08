using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualKeyBoardKey : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public VirtualKeyBoard board;
    private void Start()
    {
        text = GetComponentInChildren<Text>();
    }
    public void KeyPress() {
        board.keyPressed(text.text);
    }
}
