using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public enum Direction
    {
        LEFT, UP, DOWN, RIGHT
    }

    public Direction moveDirection;

    public float delayStep; // TEMPO ENTRE UM PASSO E OUTRO 
    public float step; // QUANTIDADE DE MOVIMENTO A CADA PASSO

    public Transform Head;

    public List<Transform> Tail;

    private Vector3 lastPos;

    public GameObject FoodPrefab;
    public GameObject TailPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveSnake");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveDirection = Direction.UP;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            moveDirection = Direction.LEFT;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            moveDirection = Direction.DOWN;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            moveDirection = Direction.RIGHT;
        }

    }

    IEnumerator MoveSnake()
    {

        yield return new WaitForSeconds(delayStep);
        Vector3 nexPos = Vector3.zero;
        switch (moveDirection)
        {

            case Direction.DOWN:
                nexPos = Vector3.down;
                Head.rotation = Quaternion.Euler(0, 0, 90);
                break;

            case Direction.LEFT:
                nexPos = Vector3.left;
                Head.rotation = Quaternion.Euler(0, 0, 0);
                break;

            case Direction.RIGHT:
                nexPos = Vector3.right;
                Head.rotation = Quaternion.Euler(0, 0, 180);
                break;

            case Direction.UP:
                nexPos = Vector3.up;
                Head.rotation = Quaternion.Euler(0, 0, -90);
                break;

        }

        nexPos *= step;
        lastPos = Head.position;
        Head.position += nexPos;

        foreach (Transform t in Tail)
        {
            Vector3 temp = t.position;
            t.position = lastPos;
            lastPos = temp;
        }

        StartCoroutine("MoveSnake");


    }
    public void Eat();
    Vector3 tailPosition = Head.position;
        if(Tail.Count > 0)
        {
        Tail.position = Tail[Tail.Count - 1].position
       }
}    
















  
  
    

          
            
           



    


    
