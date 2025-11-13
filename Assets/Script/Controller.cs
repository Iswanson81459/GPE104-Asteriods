using UnityEngine;

public class Controller : MonoBehaviour
{
    public Pawn pawn;
    public SceneController sceneController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Based on inputs, send commands to pawn
        MakeDecistions();
        ReturnToMainMenu();
    }

    private void MakeDecistions() 
    {
        if(pawn != null)
        {
            // Basic Movement
            if (Input.GetKey(KeyCode.W))
            {
                // Tell Pawn to Move Forward
                pawn.MoveForward(pawn.moveSpeed);
            }

            if (Input.GetKey(KeyCode.S))
            {
                // Tell Pawn to move backward
                pawn.MoveBackword(pawn.moveSpeed);
            }

            if(Input.GetKey(KeyCode.D))
            {
                pawn.RoatateClockwise(pawn.turnSpeed);
            }

            if (Input.GetKey(KeyCode.A))
            {
                pawn.RoatateCounterClockwise(pawn.turnSpeed);
            }


            // Tele Movement
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                pawn.TeleportForward(pawn.teleDistance);
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                pawn.TeleportBackward(pawn.teleDistance);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                pawn.TeleportLeft(pawn.teleDistance);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                pawn.TeleportRight(pawn.teleDistance);
            }

            //Shift Boost
            if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            {
                pawn.BoostSpeed(pawn.boostSpeed);
            }
            else if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
            {
                pawn.UnBoostSpeed(pawn.boostSpeed);
            }

            //shoot
            if(Input.GetKeyDown(KeyCode.Space))
            {
                pawn.Shoot(pawn.fireRate);
            }
        }
        
    }

    void ReturnToMainMenu()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            sceneController.LoadMainMenu();
        }
    }
}
