using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeatController : MonoBehaviour
{
    public float beatTempo;
    public bool hasStarted;
    public TMP_Text timer;
    private float elapsedTime;
    private TimeSpan timePlaying;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 60f;
        elapsedTime=0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted){
            if(Input.anyKeyDown) {
                hasStarted=true;
                StartCoroutine(UpdateTimer());
            }
        }
        else {
            transform.position -= new Vector3(0f, beatTempo*Time.deltaTime, 0f);
        }
    }

    private IEnumerator UpdateTimer() {
        while(hasStarted) {
            if(timePlaying>=TimeSpan.FromSeconds(120)) endGame();

            elapsedTime+=Time.deltaTime;
            timePlaying=TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = "Time\n"+timePlaying.ToString("mm':'ss");
            timer.text = timePlayingStr;

            yield return null;
        }
    }

    private void endGame(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
