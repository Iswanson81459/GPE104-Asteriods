using UnityEngine;

public class GameManager : MonoBehaviour
{
    // there can only be one esconor the one game manager 
    public static GameManager escanorTheOne;

    public float age;
    public static float hp;

    void Awake()
    {
        if(escanorTheOne == null)
        {
            escanorTheOne = this;
        }
        else
        {
            Destroy(escanorTheOne);
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
