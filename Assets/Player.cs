using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private int playerNumber;

    private Level level;
    // Start is called before the first frame update
    void Start()
    {
        level = transform.parent.gameObject.GetComponent<Level>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
