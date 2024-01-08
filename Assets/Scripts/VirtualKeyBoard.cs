using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualKeyBoard : MonoBehaviour
{
    public InputField textField;
    bool active = false;
    public Transform player;
    public void activate() {
        active = true;
        this.gameObject.SetActive(true);
        this.transform.position = new Vector3(player.position.x, player.position.y-0.3f, player.position.z)+new Vector3(player.forward.x, 0, player.forward.z);
        this.transform.LookAt(new Vector3(player.position.x,this.transform.position.y, player.position.z));
        this.transform.Rotate(0, -180, 0);
        this.transform.Rotate(30, 0, 0);
    }
    public void keyPressed(string key) {
        if (key.ToLower().Equals("del"))
        {
            if (textField.text.Length >= 1)
            {
                textField.text = textField.text.Substring(0, textField.text.Length - 1);

            }


        }
        else if (key.ToLower().Equals("exit")) {
            active = false;
        
        }
        else
        {
            textField.text += key;
        }

    
    }

    private void Update()
    {
        if (!active)
        {
            this.gameObject.SetActive(false);
        }
        else {
            this.gameObject.SetActive(true);
        }
    }
}
