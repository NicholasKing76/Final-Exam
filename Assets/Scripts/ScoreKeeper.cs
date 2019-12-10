using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreKeeper : MonoBehaviour
{
    static public int newScore = 0;
    public Text NewScore;
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    void Awake()
    {
        MusicSource.clip = MusicClip;
    }
    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        PlayerPrefs.SetInt("Score", newScore);
        MusicSource.Play();
    }

    public void DecreaseScore() // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
        MusicSource.Play();
    }
 
}
