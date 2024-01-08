using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class HigscoreList {public List<ScoreEntry> scores;
    public HigscoreList(List<ScoreEntry> sc) { scores = sc; }
}
public class AddEntryToScorebOARD : MonoBehaviour
{
    public GameObject ScoreEntry;
    public Transform content;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void refresh() {
        ManageGame.Instance.HighScores.Sort();
        foreach (Transform child in content.transform)
        {
            GameObject.Destroy(child.gameObject);
        }
        for (int i=0;  ManageGame.Instance.HighScores.Count>i; i++) {
            var uiElement = Instantiate(ScoreEntry, content);
            uiElement.GetComponent<EntrySetup>().SetUp(i+1+"",ManageGame.Instance.HighScores[i].name + "", ManageGame.Instance.HighScores[i].score + "");
            
        }
        HigscoreList hs = new HigscoreList(ManageGame.Instance.HighScores);
        string json = JsonUtility.ToJson(hs);
        PlayerPrefs.SetString("highscores",json);
        PlayerPrefs.Save();
        Debug.Log("Game Saved");
        Debug.Log(PlayerPrefs.GetString("highscores"));

    }
    
    // Update is called once per frame
    void Update()
    {
        if (ManageGame.Instance.refreshScoreBoard) {
            refresh();
            ManageGame.Instance.refreshScoreBoard = false;
        }

    }
}
