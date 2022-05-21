using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    [SerializeField] private KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)) {
            if(canBePressed)
                if(gameObject.tag=="clone")
                    Destroy(gameObject);
                else
                    gameObject.SetActive(false);
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
}
