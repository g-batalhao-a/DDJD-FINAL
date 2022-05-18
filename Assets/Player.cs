using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int playerNumber;
    private bool isActive = false;
    private Level level;
    // Start is called before the first frame update
    void Start()
    {
        level = transform.parent.gameObject.GetComponent<Level>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isActive) {return;}

        switch (playerNumber)
        {
            case 1:
                if(Input.GetKeyDown(KeyCode.A))
                {
                    // Access my parent object and call a method on it
                    level.SetFirstPlayer(1);
                }
                break;
            case 2:
                if(Input.GetKeyDown(KeyCode.L))
                {
                    level.SetFirstPlayer(2);
                }
                break;
            default:
                break;
        }
    }

    public void SetActive(bool active)
    {
        isActive = active;
    }
}
