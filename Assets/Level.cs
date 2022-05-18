using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    private int firstPlayer = -1;
    private GameObject[] players;
    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        StartCoroutine(Countdown());
        Debug.Log("Get Ready...");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void SetFirstPlayer(int playerNumber)
    {
        if (firstPlayer == -1)
        {
            Debug.Log("Player " + playerNumber + " is first");
            firstPlayer = playerNumber;
        }
    }

    private void Restart()
    {
        firstPlayer = -1;
        SetAllPlayers(false);
        StartCoroutine(Countdown());
        Debug.Log("Restarted!");
        Debug.Log("Get Ready...");
    }

    public void Reset()
    {
        firstPlayer = -1;
    }

    private IEnumerator Countdown()
    {
        // Generate random float number between 1 and 6
        float countdown = Random.Range(1f, 6f);
        yield return new WaitForSeconds(countdown);
        
        // Enable players
        SetAllPlayers(true);

        Debug.Log("GOOOOOO");
    }

    private void SetAllPlayers(bool active)
    {
        foreach (GameObject player in players)
        {
            player.GetComponent<Player>().SetActive(active);
        }
    }
}
