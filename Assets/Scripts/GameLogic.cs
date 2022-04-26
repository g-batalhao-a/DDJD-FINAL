using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private Transform gameCamera;
    
    [SerializeField] private List<Transform> players;

    private int current;
    private int numPlayers;
    
    // Start is called before the first frame update
    void Start()
    {
        players = new();

        foreach (Transform child in transform) {
            players.Add(child);
            child.GetComponent<PlayerMovement>().gameLogic = this.transform;
        }

        numPlayers = players.Count;
        current = 0;

        players[current].GetComponent<PlayerMovement>().inFront = true;

        UpdateCamera();
        InitializePlayers();
    }


    void UpdateCamera()
    {
        gameCamera.GetComponent<CameraFollow>().target = players[current].transform;
    }

    void UpdatePlayer()
    {
        players[current].GetComponent<PlayerMovement>().inFront = false;
        current = (current + 1) % numPlayers;
        players[current].GetComponent<PlayerMovement>().inFront = true;
    }

    void InitializePlayers() {
        players[0].GetComponent<PlayerMovement>().playerInFront = players[numPlayers - 1].transform;

        for (int i = 1; i < numPlayers; i++) {
            players[i].GetComponent<PlayerMovement>().playerInFront = players[i - 1].transform;
        }
        
    }
    
    public void playerAction(string player)
    {
        if (players[current].name == player) {
            UpdatePlayer();
            UpdateCamera();
        }
    }

    public void playerBlue(string player) 
    {
        Debug.Log(player + " pressed Blue!");
    }

    public void playerOrange(string player) 
    {
        Debug.Log(player + " pressed Orange!");
    }

    public void playerGreen(string player) 
    {
        Debug.Log(player + " pressed Green!");
    }

    public void playerYellow(string player) 
    {
        Debug.Log(player + " pressed Yellow!");
    }
}
