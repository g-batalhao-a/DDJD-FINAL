using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    private GameLogic gameLogic = null;
    public bool canBePressed;
    [SerializeField] private KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.Find("Canvas").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {

        if(gameObject.transform.position.y <= -2.5 && gameObject.tag=="clone")
            Destroy(gameObject);

    }


    public void onAction() {
        if (gameLogic) gameLogic.playerAction(this.name, this.transform.position.y);
        Destroy(gameObject);
    }



}
