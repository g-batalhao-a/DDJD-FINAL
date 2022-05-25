using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUIManager : MonoBehaviour
{
    [SerializeField] private string beforeText = "";
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Change text
        GetComponent<TextMeshProUGUI>().text = beforeText + score;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }

    public void AddScore(int score)
    {
        this.score += score;
    }
}
