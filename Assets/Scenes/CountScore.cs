using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountScore : MonoBehaviour{    
    private int player_one_score = 0;
    private int player_two_score = 0;

    public TextMeshProUGUI score_text;


    void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.name == "RightGoal"){
            player_one_score += 1;
        } else if (other.gameObject.name == "LeftGoal"){
            player_two_score += 1;
        }

        score_text.text = player_one_score + " | " + player_two_score;
    }
}
