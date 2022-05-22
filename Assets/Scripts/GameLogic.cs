using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    [SerializeField] private Transform gameCamera;
    [SerializeField] private RectTransform scores;

    private List<Transform> players;
    private int currentPlayer;
    private int numPlayers;

    private List<TextMeshProUGUI> playerScores;
    private List<TextMeshProUGUI> roundScores;
    private float currentScore = 0;

    private float Timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        InitializePlayers();
        InitializeScores();
        UpdateCamera();
        Timer = UnityEngine.Random.Range(10, 60);
    }

    void InitializePlayers() 
    {
        players = new();

        foreach (Transform child in transform) {
            players.Add(child);
            child.GetComponent<PlayerMovement>().gameLogic = this.transform;
        }

        numPlayers = players.Count;
        currentPlayer = 0;

        players[currentPlayer].GetComponent<PlayerMovement>().inFront = true;

        players[0].GetComponent<PlayerMovement>().playerInFront = players[numPlayers - 1].transform;

        for (int i = 1; i < numPlayers; i++) {
            players[i].GetComponent<PlayerMovement>().playerInFront = players[i - 1].transform;
        }
    }

    void InitializeScores()
    {
        playerScores = new();
        roundScores = new();

        foreach (Transform child in scores) {
            playerScores.Add(child.GetChild(0).GetComponent<TextMeshProUGUI>());
            roundScores.Add(child.GetChild(1).GetComponent<TextMeshProUGUI>());
        }
    }

    void UpdateCamera()
    {
        gameCamera.GetComponent<CameraFollow>().target = players[currentPlayer].transform;
    }

    void UpdatePlayer()
    {
        currentScore = 0;
        roundScores[currentPlayer].text = currentScore.ToString();

        players[currentPlayer].GetComponent<PlayerMovement>().inFront = false;
        currentPlayer = (currentPlayer + 1) % numPlayers;
        players[currentPlayer].GetComponent<PlayerMovement>().inFront = true;
    }

    void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0) {
            // Die
            Debug.Log("Dieeeee!");
            UpdatePlayer();
            UpdateCamera();
            Timer = UnityEngine.Random.Range(10, 60);
        } else {
            currentScore += 100 * Time.deltaTime;
            roundScores[currentPlayer].text = ((int)currentScore).ToString();
        }
    }
    
    public void playerAction(string player)
    {
        if (players[currentPlayer].name == player) {
            playerScores[currentPlayer].text = (Int32.Parse(playerScores[currentPlayer].text) + (int)currentScore).ToString();
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
