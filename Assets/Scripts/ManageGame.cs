using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour
{
    // Start is called before the first frame update
    public int score = 0;
    public int wave = 1;
    public bool plng = false;
    public bool refreshScoreBoard = true;
    public bool scoreEntered = true;
    public int zombieQuota = 0;
    public int zombiesLeft = 0;
    public int zombiesSpawned = 0;
    public List<ScoreEntry> HighScores = new List<ScoreEntry>();
    public static ManageGame Instance { get; private set; }
    void Start()
    {
        plng = false;
        try
        {
            string jsonString = PlayerPrefs.GetString("highscores");
            HighScores = JsonUtility.FromJson<HigscoreList>(jsonString).scores;
        }
        catch {
            Debug.Log("Failed to load HighScores");
            HighScores = new List<ScoreEntry>();


        }

        //StartWave();
    }
    public void startGame() {
        plng = true;
        wave = 1;
        score = 0;
        StartWave();
    
    }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

        public void StartWave() {
        zombieQuota = (int)Mathf.Pow(wave ,2f);
        zombiesLeft = zombieQuota;
        zombiesSpawned = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(plng);
        if ( zombiesLeft <= 0) {
            Debug.Log("Next wave");
            wave++;
            StartWave();
        }
    }
}
