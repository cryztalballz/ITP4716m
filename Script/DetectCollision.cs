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
        }
    }
}
