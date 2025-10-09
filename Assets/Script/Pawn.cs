using UnityEngine;

public class Pawn : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;
    public float turnSpeed;
    public float boostSpeed;

    [Header("Teleport")]
    public float teleDistance;
    public float teleDistMin;
    public float teleDistMax;

    [Header("Componets")]
    public Health health;
    public Death death;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // load the health component from the object
        health = GetComponent<Health>();
        // load the death componen from the object
        death = GetComponent<Death>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveForward(float moveSpeed)
    {
        // Change my pawn position -- in the forward direction, magnitude of moveSpeed
        // get the transform component
        transform.position = transform.position + ((transform.up * moveSpeed) * Time.deltaTime );

    }
    public void MoveBackword(float moveSpeed) 
    {
        transform.position = transform.position + ((-transform.up * moveSpeed) * Time.deltaTime);
    }

    public void RoatateClockwise ( float rotateValue) 
    {
        transform.Rotate(0, 0f, -rotateValue * Time.deltaTime);
    }

    public void RoatateCounterClockwise(float rotateValue)
    {
        transform.Rotate(0, 0f, rotateValue * Time.deltaTime);
    }

    public void TeleportForward(float TeleDistance)
    {
        float moveDist = Random.Range(teleDistMin, teleDistMax);

        transform.Translate(Vector3.up * moveDist, Space.World);
    }
    public void TeleportBackward(float TeleDistance)
    {
        float moveDist = Random.Range(teleDistMin, teleDistMax);

        transform.Translate(Vector3.down * moveDist, Space.World);
    }
    public void TeleportLeft(float TeleDistance)
    {
        float moveDist = Random.Range(teleDistMin, teleDistMax);

        transform.Translate(Vector3.left * moveDist, Space.World);
    }
    public void TeleportRight(float TeleDistance)
    {
        float moveDist = Random.Range(teleDistMin, teleDistMax);

        transform.Translate(Vector3.right * moveDist, Space.World);
    }

    public void BoostSpeed(float boostSpeed)
    {
        this.moveSpeed += boostSpeed;
    }

    public void UnBoostSpeed(float boostSpeed)
    {
        this.moveSpeed -= boostSpeed;
    }
}
