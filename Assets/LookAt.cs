using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class LookAt : MonoBehaviour
{
   
    
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(Look()); 
        
        
    }
    IEnumerator Look()
    {
        Debug.Log("dp");

        TextMeshProUGUI text = GameObject.FindGameObjectWithTag("Respawn").GetComponent<TextMeshProUGUI>();
        while (true)
        {
            Debug.Log("dp");
            transform.LookAt(Camera.main.transform.position);
            text.text = $"Distance = {Vector3.Distance(transform.position, Camera.main.transform.position)}";
            transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
            yield return new WaitForSeconds(.1f);
        }
    }
}
