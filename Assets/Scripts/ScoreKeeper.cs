using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
   private int Score;
    public static ScoreKeeper instance;
    void ManageSingleton()
    {
        if (instance!=null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Awake()
    {
        ManageSingleton();
    }
    public int  getScore ()
    {
        return Score;
    }
    public void ModifyScore(int value)
    {
       Score +=value;
        Mathf.Clamp(Score, 0, int.MaxValue);
        Debug.Log(Score);
    }
    public int HighScore
    {
        get => PlayerPrefs.GetInt("HighScore", 0);
        set
        {
            if (value > PlayerPrefs.GetInt("HighScore",0))
            {
                PlayerPrefs.SetInt("HighScore", value);
            }
        }
    }

    public void ResetScore()
    {
        Score = 0;
    }
}
