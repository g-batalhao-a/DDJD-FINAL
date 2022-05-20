using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Velocity = 2;
    private Vector3 direction;
    private Rigidbody playerRb;
    private PlayerAction playerAction;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAction = GetComponent<PlayerAction>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(0, 0, Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        playerRb.MovePosition
            (playerRb.position +
            (direction * Time.deltaTime * Velocity));
    }
}
