using JetBrains.Annotations;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public Pawn[] meteorPawn ;
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
        for(int i = 0; i < meteorPawn.Length; i++)
        {
            if(meteorPawn != null && targetToMoveTowards != null)
                meteorPawn[i].MoveTowards(targetToMoveTowards);
        }
        
    }


}
