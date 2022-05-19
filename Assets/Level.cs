using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum GunMiniGameState {
    Preparing,
    WaitingForCountdown,
    WaitingforPlayerToFire,
    Finished
}

public class Level : MonoBehaviour
{
    private int playerLeft = 1;
    private int playerRight = 2;
    private int playerBenchLeft = 3;
    private int playerBenchRight = 4;
    
    private int[] winners = new int[4];
    private int[] losers = new int[4];
    private Vector3 playerLeftPosition;
    private Vector3 playerRightPosition;
    private Vector3 playerBenchLeftPosition;
    private Vector3 playerBenchRightPosition;
    private GameObject[] players;
    
    private GunMiniGameState currentState = GunMiniGameState.Preparing;
    private int currentRound = 1;

    // Start is called before the first frame update
    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
        playerLeftPosition = players[0].transform.position;
        playerRightPosition = players[1].transform.position;
        playerBenchLeftPosition = players[2].transform.position;
        playerBenchRightPosition = players[3].transform.position;

        updateRound(1);

    }

    // Update is called once per frame
    void Update()
    {
        if(currentState != GunMiniGameState.WaitingforPlayerToFire) 
        {
            return;
        }

        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.L))
        {
            if(Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.L))
            {
                Debug.Log("There was a tie!");
            }
            else if(Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("Player Left won");
                SetScore(playerLeft);
                currentRound++;    
            }
            else if(Input.GetKeyDown(KeyCode.L))
            {
                Debug.Log("Player Right won");
                SetScore(playerRight);
                currentRound++;
            }
            updateRound(currentRound);
        }
    }


    private void updateRound(int round)
    {
        if(round > 4)
        {
            FinishGame();
            return;
        }
        currentState = GunMiniGameState.Preparing;
        Debug.Log("Round " + round);

        PrepareRound(round);
        
        StartCoroutine(DoRound());
    }

    private void PrepareRound(int round){
        switch (round)
        {
            case 1:
                Debug.Log("Prepare for the first round");
                return;
            case 2:
                Debug.Log("Prepare for the second round");
                playerLeft = 3;
                playerRight = 4;
                playerBenchLeft = 1;
                playerBenchRight = 2;
                

                break;
            case 3:
                Debug.Log("Prepare for the third round");
                playerLeft = losers[0];
                playerRight = losers[1];
                playerBenchLeft = winners[0];
                playerBenchRight = winners[1];
                break;
            case 4:
                Debug.Log("Prepare for the forth round");
                playerLeft = winners[0];
                playerRight = winners[1];
                playerBenchLeft = losers[0];
                playerBenchRight = losers[1];
                break;

            default:
                break;
        }
        Debug.Log("Player Left: " + playerLeft);
        Debug.Log("Player Right: " + playerRight);
        updatePlayers();
    }

    private void updatePlayers()
    {

        UpdatePlayersPosition();

    }

    private void UpdatePlayersPosition()
    {
        players[playerLeft - 1].transform.position = playerLeftPosition;
        players[playerRight - 1].transform.position = playerRightPosition;
        players[playerBenchLeft - 1].transform.position = playerBenchLeftPosition;
        players[playerBenchRight - 1].transform.position = playerBenchRightPosition;
    }

    public void SetScore(int playerNumber)
    {        
        winners[currentRound - 1] = playerNumber;
        losers[currentRound - 1] = (playerNumber == playerLeft) ? playerRight : playerLeft;
        Debug.Log("Player " + playerNumber + " won the round");
        Debug.Log("Player " + ((playerNumber == playerLeft) ? playerRight : playerLeft) + " lost the round");
        
    }

    private IEnumerator DoRound()
    {
        // Generate random float number between 1 and 6
        float countdown = Random.Range(1f, 6f);
        currentState = GunMiniGameState.WaitingForCountdown;
        yield return new WaitForSeconds(countdown);
        
        currentState = GunMiniGameState.WaitingforPlayerToFire;
        Debug.Log("GOOOOOO");
    }

    private void FinishGame()
    {
        currentState = GunMiniGameState.Finished;
        Debug.Log("Winner1: " + winners[3]);
        Debug.Log("Winner2: " + losers[3]);
        Debug.Log("Winner3: " + winners[2]);
        Debug.Log("Winner4: " + losers[2]);
        
    }
}
