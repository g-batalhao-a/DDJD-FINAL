using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public GameObject Bread;
    public bool HasBreadAttached = false;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        Bread = GameObject.FindWithTag("Bread");
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Grab();
        BreadTaken();
    }

    private void BreadTaken()
    {
        if (HasBreadAttached)
        {
            Bread.transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z - 0.5f
            );
        }
    }

    private void Grab()
    {
        if (Input.GetButtonDown("Fire1") && !HasBreadAttached)
        {
            // make animation
            if (Vector3.Distance(transform.position, Bread.transform.position) < 1)
            {
                HasBreadAttached = true;
                playerRb.transform.localScale = new Vector3(
                    playerRb.transform.localScale.x,
                    playerRb.transform.localScale.y,
                    playerRb.transform.localScale.z - 1
                );
            }
        }
    }
}
