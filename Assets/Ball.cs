using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    private int score;

    private GameObject scoretext;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        this.scoretext = GameObject.Find("ScoreText");
        this.scoretext.GetComponent<Text>().text = "score:" + score;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)

    {
        if(other.gameObject.tag =="LargeCloudTag")
        {
            score += 50;
        }
        else if(other.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
            score += 40;
        }
        else if(other.gameObject.tag == "SmallStarTag")
        {
            score += 20;
        }
        this.scoretext.GetComponent<Text>().text = "score:"+score;
    }
}
