using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class player : MonoBehaviour
{
    public GameObject Maze;
    public Rigidbody Player;
    public float ballSpeed;
    private Vector3 Movement;
    private bool movingFoward = false;
    public float slowDownBall;
  


    // public float turnSpeed; 
    // Start is called before the first frame update
    void Start()
    {
       
        Player = GetComponent<Rigidbody>();
        Maze = GameObject.FindWithTag("Maze");
      
      
        
    }

    void FixedUpdate()
    {
        playerControl(/*Player, ballSpeed*/);
        mazeTurn(Maze, Player);
    }
    
   

    private void playerControl(/*Rigidbody Player, float ballSpeed*/)
    {
        if (movingFoward == false && Input.GetKey(KeyCode.Space))
        { 
            Player.velocity  /= slowDownBall;
            
           
        }
        if(movingFoward == false)
        {
           Debug.Log("Velocity is :" + Player.velocity);
           Debug.Log("Rotation is :" + Player.rotation);
            Debug.Log("Force is:" + Player.transform.forward);
        }
        if (Input.GetKey(KeyCode.W))
        {
            
            Player.AddForce(Vector3.forward * ballSpeed);
            Debug.Log("Velocity is :" + Player.velocity);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            Player.AddForce(Vector3.back * ballSpeed);
        }

        
    }
    private void mazeTurn(GameObject Maze,Rigidbody Player)
    {
        if (Input.GetKey(KeyCode.D))
        {

            Maze.transform.RotateAround(Player.transform.position, Vector3.down, 160 * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {

            Maze.transform.RotateAround(Player.transform.position, Vector3.up, 160 * Time.fixedDeltaTime);
        }
     
    }
}
