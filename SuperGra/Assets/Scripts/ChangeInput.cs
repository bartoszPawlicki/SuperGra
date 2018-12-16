using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInput : MonoBehaviour
{
    public bool isMouseOn;
    // Start is called before the first frame update
    void Start()
    {
        isMouseOn = true;
    }

    public void OnClick()
    {
        isMouseOn = !isMouseOn;
        Debug.Log("click");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
