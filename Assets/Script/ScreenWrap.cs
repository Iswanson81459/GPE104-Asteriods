using UnityEngine;


public class ScreenWrap : MonoBehaviour
{
    /*
     * Credit to MatalStorm Games 
     * Unity Basics - Screen Wrapping
     * https://www.youtube.com/watch?v=zWy29yeFNX8&t=761s
     */

    private Rigidbody2D myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        float rightSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x;
        float leftSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).x;

        float topOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y;
        float bottomOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y;

        if(screenPos.x <= 0)
        {
            transform.position = new Vector2(rightSideOfScreenInWorld, transform.position.y);
        }

        else if (screenPos.x >= Screen.width)
        {
            transform.position = new Vector2(leftSideOfScreenInWorld, transform.position.y);
        }

        else if (screenPos.y >= Screen.height)
        {
            transform.position = new Vector2(transform.position.x, bottomOfScreenInWorld);
        }
        else if (screenPos.y <= 0)
        {
            transform.position = new Vector2(transform.position.x, topOfScreenInWorld);
        }
    }
}
