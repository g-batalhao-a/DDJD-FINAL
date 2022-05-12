using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Boat1Movement : MonoBehaviour
{
    public Vector3 leftCenter, rightCenter;
    
    public float speed = 100f;
    
    private Bounds bounds;
    private GameControlls gameControlls;
    
    // Start is called before the first frame update
    void Start()
    {
        gameControlls = new GameControlls();
        
        gameControlls.Player1.Enable();
        gameControlls.Player2.Enable();
        
        getLeftCenter();
        getRightCenter();
    }

    // Update is called once per frame
    void Update()
    {
        getLeftCenter();
        getRightCenter();
        
        
        if (gameControlls.Player1.Action.IsPressed()) {
            transform.RotateAround(rightCenter, transform.up, speed * Time.deltaTime);
        }
        
        if (gameControlls.Player2.Action.IsPressed()) {
            transform.RotateAround(leftCenter, -transform.up, speed * Time.deltaTime);
        }
    }
    
    private void getLeftCenter() {
        leftCenter = transform.GetChild(0).position;
    }
    
    private void getRightCenter() {
        rightCenter = transform.GetChild(1).position;
    }
}
