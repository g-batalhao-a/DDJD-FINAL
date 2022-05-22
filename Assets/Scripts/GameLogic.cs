using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public TMP_Text blueScore;
    public TMP_Text orangeScore;
    public TMP_Text greenScore;
    public TMP_Text yellowScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playerAction(string player, float height){
        int score = 5;

        print(height);
        if(Math.Abs(height) > 0.25f){
            print("Hit!");
            score += 5;
        } 
        else if(Math.Abs(height) > 0.05f){
            print("Great!");
            score+= 25;
        } 
        else{
            print("Perfect!");
            score += 45;
        } 
        if(player.Contains("L")) blueScore.text = (Int32.Parse(blueScore.text) + score).ToString();
        if(player.Contains("U")) orangeScore.text = (Int32.Parse(orangeScore.text) + score).ToString();
        if(player.Contains("D")) greenScore.text = (Int32.Parse(greenScore.text) + score).ToString();
        if(player.Contains("R")) yellowScore.text = (Int32.Parse(yellowScore.text) + score).ToString();
    
    }

    public void playerPenalty(string player){
        if(player.Contains("L")) blueScore.text = (Int32.Parse(blueScore.text) -10).ToString();
        if(player.Contains("U")) orangeScore.text = (Int32.Parse(orangeScore.text) -10).ToString();
        if(player.Contains("D")) greenScore.text = (Int32.Parse(greenScore.text) -10).ToString();
        if(player.Contains("R")) yellowScore.text = (Int32.Parse(yellowScore.text) -10).ToString();
    
    }
}
