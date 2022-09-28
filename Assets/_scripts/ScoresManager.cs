using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoresManager : MonoBehaviour
{
    public static ScoresManager instance;

    int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        Debug.Log(score);

    }
}
