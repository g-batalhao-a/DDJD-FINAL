using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    private MeshRenderer currentMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private Material newMaterial;
    [SerializeField] private KeyCode key;
    // Start is called before the first frame update
    void Start()
    {
        currentMaterial = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(key)) {
            currentMaterial.material = newMaterial;
        }
        
        if(Input.GetKeyUp(key))
        {
            currentMaterial.material = defaultMaterial;
        }
    }
}
