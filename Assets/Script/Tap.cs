using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Tap : MonoBehaviour
{
    public string direction;


    
        

    // Update is called once per frame
    void Update()
        {
        
        }

    void OnMouseDown()
    {
        Debug.Log( "Tap" + direction );
    }

   

}