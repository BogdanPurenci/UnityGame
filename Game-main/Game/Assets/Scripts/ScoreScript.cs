using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text MyScoreText;
    private int ScoreNum;
  



    // Start is called before the first frame update
    void Start()
    {
        ScoreNum= 0;
        MyScoreText.text = "SCORE : " + ScoreNum;
      

    }

    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.tag == "Coin")
        {
            ScoreNum++;
            Destroy(Coin.gameObject);
            MyScoreText.text = "SCORE: " + ScoreNum;
        }
    }

}
