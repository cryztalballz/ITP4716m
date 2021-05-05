using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    public AudioClip VideoGameEffects;
    

    void OnCollisionEnter2D(Collision2D coll)
    {

        string tag = coll.collider.gameObject.tag;

        if (tag == "pick_me")
        {
            Destroy(coll.collider.gameObject);
            AudioSource.PlayClipAtPoint(VideoGameEffects, new Vector2(5, 1)); 
            SceneManager.LoadScene("SecondMap");
        }
        if (tag == "pick_me2")
        {
            AudioSource.PlayClipAtPoint(VideoGameEffects, new Vector2(5, 1));
            SceneManager.LoadScene("FinalMap");
        }
        else if (tag == "Ship")
        {
            AudioSource.PlayClipAtPoint(VideoGameEffects, new Vector2(5, 1));
            SceneManager.LoadScene("YouWin");
        }
        else if (tag == "Monster")
        {
            GameObject.FindObjectOfType<Life>().DecreaseLife();
        }
        
    }
}
