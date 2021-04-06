using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    void OnGUI()
    {
        if (GUILayout.Button("Restart"))
	{
		SceneManager.LoadScene("mario");
	}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
