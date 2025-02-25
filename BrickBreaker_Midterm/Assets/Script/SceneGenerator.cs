using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class SceneGenerator : MonoBehaviour
{
    private const int BRICK_X = 9;
    private const int BRICK_Y = 4;

    private const int BRICK_Row = 3;
    public GameObject tile;

    public int tolCount;
    public static SceneGenerator sc;

    public int totalBricks;
    int J;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        J=0;
        sc=this;
        
         for (int i = -BRICK_X; i <= BRICK_X; i++)
         {
            for (int j = 0; j < BRICK_Row; j++)
            {
                Instantiate(tile, new Vector3(i, 4-j*0.5f, 0), quaternion.identity);
                J++;
            }
         }
         Debug.Log("Total Bricks: "+ J);
         totalBricks = J; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BrickHit(){
        totalBricks--;
        Debug.Log("Baki ketli che:"+totalBricks);
        if (totalBricks<1)
        {
            Debug.Log("You Won");
        }
    }
}
