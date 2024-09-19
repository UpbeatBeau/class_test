using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables
    public TextMeshProUGUI score;
    
    public TextMeshProUGUI p3score;

    public int p3sc_num;

    public int sc_num;
    
    // Start is called before the first frame update
    void Start()
    {
        //Make the score 0
        sc_num = 0;
        p3sc_num = 0;
        //score.text = "Score: " + sc_num;
    }

    // Update is called once per frame
    void Update()
    {
        //make the score texts say Score: and a number
        score.text = "Score: " + sc_num;
        p3score.text = "Score: " + p3sc_num;
    }
}
