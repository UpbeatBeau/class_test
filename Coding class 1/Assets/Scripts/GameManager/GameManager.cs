using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI score;
    
    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        score.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
