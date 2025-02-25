using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float PADDLE_SPEED = 0.0055f;

    public float speed = 5;
    public float maxX = 7.5f;

    float moveHorizontal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey("left"))
        {
            transform.Translate(-PADDLE_SPEED,0,0);
        }
        else if (Input.GetKey("right"))
        {
            transform.Translate(PADDLE_SPEED,0,0);
        }*/

        moveHorizontal = Input.GetAxis("Horizontal");
        if ((moveHorizontal>0 && transform.position.x<maxX) ||(moveHorizontal<0 && transform.position.x>-maxX)
        )
        {
            transform.position+=Vector3.right*moveHorizontal*speed*Time.deltaTime;
        }
        
    }
}
