using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   
   

    // Update is called once per frame
    void Update(){
        if (Input.GetButtonDown("Submit")) {
            SceneManager.LoadScene("MainMap");
        }
    }
}
