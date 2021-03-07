using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMobileInput : MonoBehaviour
{

    public TextMesh textMesh;


    // Start is called before the first frame update
    void Start()
    {
        textMesh = gameObject.GetComponentInChildren<TextMesh>();

        Debug.Log("hello world");
    }

    // Update is called once per frame
    void Update()
    {
        
        //testing single touch
        if (Input.touchCount > 0)
        {
            Touch singleTouch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(singleTouch.position);
            //Debug.Log(touchPosition);
            Debug.Log(singleTouch);
        }
    }

    
    void OnEnable()
    {
        Application.logMessageReceived += LogMessage;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= LogMessage;
    }

    public void LogMessage(string message, string stackTrace, LogType type)
    {
        if (textMesh.text.Length > 300)
        {
            textMesh.text = message + "\n";
        }
        else
        {
            textMesh.text += message + "\n";
        }
    }

}
