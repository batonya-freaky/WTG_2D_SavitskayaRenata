using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timberman : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ChangeDirection(string direction)
    {
        if (direction == "LEFT")
        {
            gameObject.transform.localPosition = new Vector3(5f, gameObject.transform.localPosition.y , gameObject.transform.localPosition.z);
            gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);

        }
        else
        {
            gameObject.transform.localPosition = new Vector3(11.4f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
            gameObject.transform.rotation = Quaternion.AngleAxis(0, Vector3.up);
        }
    }

    public void Die()
    {
        gameObject.transform.Find("dead").gameObject.SetActive(true);
        gameObject.transform.Find("Timberman").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
