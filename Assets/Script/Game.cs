using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public Timberman timberman;
    public TrunkManager trunkManager; 

    void Start()
    {
        // 
    }

    void Update()
    {
        // 
    }

    public void OnTap(string direction)
    {
        // 
        timberman.ChangeDirection(direction);
        

        // проверка
        if (direction == trunkManager.GetDirectionFirstTrunk())
        {
            // lost
            Debug.Log("You lost!");
            timberman.Die();
        }
        else
        {
            // cut
            trunkManager.CutFirstTrunk();
        }
    }
}
