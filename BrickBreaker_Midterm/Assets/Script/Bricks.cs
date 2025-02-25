using UnityEngine;

public class Bricks : MonoBehaviour
{
    public int maxHit;
    int hit;
    public Sprite[] sprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        hit=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HitDetect(){
        if (maxHit>1)
        {
            maxHit--;
            hit++;
            Debug.Log(maxHit);
            GetComponent<SpriteRenderer>().sprite = sprites[hit-1];
        }
        else
        {
            SceneGenerator.sc.BrickHit();
            Destroy(gameObject);
        }
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag =="Ball")
        {
            Debug.Log("Brick FUNcc");
            HitDetect();
        }
    }*/

}
