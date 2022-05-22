using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private GameLogic gameLogic = null;
    public bool canBePressed;
    [SerializeField] private KeyCode key;
    private bool penalty;
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.Find("Canvas").GetComponent<GameLogic>();
        penalty=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)) {
            if(canBePressed){
                onAction();
                Destroy(gameObject);
            }
            else
            {
                /*
                onPenalty();
                penalty=true;
                disableKey();*/
            }
                
        }


        if(gameObject.transform.position.y <= -2.5 && gameObject.tag=="clone")
                Destroy(gameObject);
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="GameController")
            canBePressed = true;
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag=="GameController"){
            canBePressed = false;
        }
    }

    public void onAction() {
        if (gameLogic) gameLogic.playerAction(this.name, this.transform.position.y);
    }

    public void onPenalty() {
        if(gameLogic) gameLogic.playerPenalty(this.name);
    }

    private IEnumerator disableKey() {
        yield return new WaitForSeconds(2f);
        penalty=false;
    }
}
