using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public Transform playerInFront;

    public Transform gameLogic = null;

    public int playerNumber = 0;
    
    public bool inFront = false;

    float speed = 10.0f;

    const float EPSILON = 2f;

    // Start is called before the first frame update
    void Start()
    {
        GameControlls gameControlls = new GameControlls();

        switch (playerNumber) {
            case 1:
                gameControlls.Player1.Enable();
                gameControlls.Player1.Action.performed += onAction;
                gameControlls.Player1.Blue.performed += onBlue;
                gameControlls.Player1.Orange.performed += onOrange;
                gameControlls.Player1.Green.performed += onGreen;
                gameControlls.Player1.Yellow.performed += onYellow;
                break;
            case 2:
                gameControlls.Player2.Enable();
                gameControlls.Player2.Action.performed += onAction;
                gameControlls.Player2.Blue.performed += onBlue;
                gameControlls.Player2.Orange.performed += onOrange;
                gameControlls.Player2.Green.performed += onGreen;
                gameControlls.Player2.Yellow.performed += onYellow;
                break;
            case 3:
                gameControlls.Player3.Enable();
                gameControlls.Player3.Action.performed += onAction;
                gameControlls.Player3.Blue.performed += onBlue;
                gameControlls.Player3.Orange.performed += onOrange;
                gameControlls.Player3.Green.performed += onGreen;
                gameControlls.Player3.Yellow.performed += onYellow;
                break;
            case 4:
                gameControlls.Player4.Enable();
                gameControlls.Player4.Action.performed += onAction;
                gameControlls.Player4.Blue.performed += onBlue;
                gameControlls.Player4.Orange.performed += onOrange;
                gameControlls.Player4.Green.performed += onGreen;
                gameControlls.Player4.Yellow.performed += onYellow;
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (inFront) {
            /* if (Input.GetKey(KeyCode.DownArrow)) {
                transform.Rotate(90.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
            } else if (Input.GetKey(KeyCode.UpArrow)) {
                transform.Rotate(-90.0f * Time.deltaTime, 0.0f, 0.0f, Space.Self);
            }  */

            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        } 
        else {
            transform.LookAt(playerInFront.position);

            if ((transform.position - playerInFront.position).magnitude > EPSILON) {
                transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
            }
        }
    }

    public void onAction(InputAction.CallbackContext context) 
    {
        if (gameLogic) gameLogic.GetComponent<GameLogic>().playerAction(this.name);
    }

    public void onBlue(InputAction.CallbackContext context) 
    {
        if (gameLogic) gameLogic.GetComponent<GameLogic>().playerBlue(this.name);
    }

    public void onOrange(InputAction.CallbackContext context) 
    {
        if (gameLogic) gameLogic.GetComponent<GameLogic>().playerOrange(this.name);
    }

    public void onGreen(InputAction.CallbackContext context) 
    {
        if (gameLogic) gameLogic.GetComponent<GameLogic>().playerGreen(this.name);
    }

    public void onYellow(InputAction.CallbackContext context) 
    {
        if (gameLogic) gameLogic.GetComponent<GameLogic>().playerYellow(this.name);
    }
}
