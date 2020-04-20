using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostScores : MonoBehaviour
{
    
    void Start()
    {
        //find out what this is/does
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        //create WWWform to store data
        WWWForm form = new WWWForm();

        //add fields to form
        form.AddField("myfield", "myData");

        //Post data to url - need to change the url ...when I know what it is!
        UnityWebRequest www = UnityWebRequest.Post("http://www.my-server.com/myform", form);

        //return ienumerator
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }

    
}
