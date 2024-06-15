using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon_Controller : MonoBehaviour
{
    
    void Update()
    {
        StartCoroutine(Rotate());
    }

    IEnumerator Rotate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            transform.position.y,
            transform.position.z
            ));

        if (Input.GetMouseButtonDown(0)&& mousePos.x<0)
        {
            transform.Rotate(0f,0f,30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f,0f,30f);
        }
        else if (Input.GetMouseButtonDown(0)&& mousePos.x>0)
        {
            transform.Rotate(0f,0f,-30f);
            yield return new WaitForSeconds(0.1f);
            transform.Rotate(0f,0f,-30f);
        }
        yield return null;
    }

}
