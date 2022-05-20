using UnityEngine;

public class HumanMovement : MonoBehaviour
{
    private Quaternion startPosition;
    private float timer = 0;
    private int timeOut = 0;
    private Rigidbody humanRb;
    private bool isDistracted = false;
    private PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.rotation;
        humanRb = GetComponent<Rigidbody>();
        playerMovement = GameObject.FindWithTag("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeOut)
        {
            timer = 0;
            if (isDistracted)
            {
                timeOut = Random.Range(1, 10);
                transform.Rotate(Vector3.up, -90 + 180 * Random.Range(0, 2));
                playerMovement.Velocity = 2;
            }
            else
            {
                timeOut = Random.Range(1, 5);
                transform.rotation = startPosition;
                playerMovement.Velocity = 0;
            }

            isDistracted = !isDistracted;
        }
    }
}
