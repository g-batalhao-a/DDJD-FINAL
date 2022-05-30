using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int playerNumber;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool isMoving = false;
    private int interpolationFramesCount = 45;
    private int elapsedFrames = 0; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Stop player from moving when
        if(elapsedFrames > interpolationFramesCount)
        {  
            Debug.Log("STOPED");
            elapsedFrames = 0;
            isMoving = false;
        }

        if(isMoving){
            
            float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;

            transform.position = Vector3.Lerp(startPosition, endPosition, interpolationRatio);
            elapsedFrames++;
        }
    }

    public void GoToPosition(Vector3 position)
    {
        if(position == transform.position)
        {
            return;
        }
        
        startPosition = transform.position;
        endPosition = position;

        isMoving = true;
    }
}
