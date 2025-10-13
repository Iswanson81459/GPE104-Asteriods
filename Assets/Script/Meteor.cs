using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Pawn meteorPawn;
    public Pawn targetToMoveTowards;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MakeDecistion();    
    }

    void MakeDecistion() 
    {
        meteorPawn.MoveTowards(targetToMoveTowards);
    }


}
