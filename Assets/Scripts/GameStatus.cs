using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [SerializeField] int pointsPerBlockDestroyed = 100;
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddToScore()
    {

        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}
