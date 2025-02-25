using UnityEngine;

public class Ball : MonoBehaviour
{
    private float xVel;
    private float yVel;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xVel = 0.0055f;
        yVel = -0.0055f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xVel,yVel,0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag =="Paddle")
        {
              yVel = -yVel; 
        }
        else if (collision.transform.tag =="Brick")
        {
            Debug.Log("Ball Funcc");
            yVel = -yVel;
            //xVel= Random.Range(-xVel,xVel);
            collision.transform.GetComponent<Bricks>().HitDetect();
             
        }
        else if (collision.transform.tag =="Wall")
        {
            yVel = -yVel;
            xVel = Random.Range(-xVel,xVel);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag =="Bottom")
        {
            Debug.Log("GameOver");
            Destroy(this.gameObject);
        }
    }
}
