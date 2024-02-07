using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    private float score; 
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player")!=null)
        {
            score +=1*Time.deltaTime;
            scoreText.text=((int)score).ToString();
        }
        
    }
}
