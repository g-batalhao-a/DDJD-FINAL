using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private MeshRenderer currentMaterial;
    private GameLogic gameLogic = null;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material newMaterial;
    [SerializeField] private KeyCode key;
    private NoteObject ball;
    private bool penalty;
    // Start is called before the first frame update
    void Start()
    {
        ball = null;
        currentMaterial = GetComponent<MeshRenderer>();
        gameLogic = GameObject.Find("Canvas").GetComponent<GameLogic>();
        penalty=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)) {
            currentMaterial.material = newMaterial;
            if(ball){
                ball.onAction();
                ball=null;
            }
            else
                onPenalty();
        }
        
        if(Input.GetKeyUp(key))
        {
            currentMaterial.material = defaultMaterial;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag=="clone")
            ball=other.GetComponent<NoteObject>();
        
    }

    private void OnTriggerExit(Collider other) {
        if(other.tag=="clone"){
            ball = null;
        }
    }

    public void onPenalty() {
        if(gameLogic) gameLogic.playerPenalty(this.name);
    }

    private IEnumerator disableKey() {
        yield return new WaitForSeconds(2f);
        penalty=false;
    }
}
