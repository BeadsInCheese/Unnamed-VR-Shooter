using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class ScoreEntry : IComparable
{
    public string name;
    public int score;
    public ScoreEntry(string name,int score) {
        this.name = name;
        this.score = score;
    }

    public int CompareTo(object obj)
    {
        if (obj is ScoreEntry)
        {

            if (this.score > ((ScoreEntry)obj).score)
            {
                return -1;
            }
            if (this.score < ((ScoreEntry)obj).score)
            {
                return 1;
            }
            return 0;
        }
        else { return 0; }
    }


}
