using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddnewScoreEntry : MonoBehaviour
{
    public InputField t;
    // Start is called before the first frame update
    public void addScore()
    {
        if (ManageGame.Instance.score != 0 && !t.text.Equals("")&&!ManageGame.Instance.scoreEntered)
        {
            ManageGame.Instance.scoreEntered = true;
            ManageGame.Instance.HighScores.Add(new ScoreEntry(t.text, ManageGame.Instance.score));
            Debug.Log(ManageGame.Instance.HighScores.ToString());
            ManageGame.Instance.refreshScoreBoard = true;
            t.text = "";
        }
        
    }
}
