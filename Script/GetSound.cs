using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSound : MonoBehaviour
{
    public AudioClip RollDice;

    AudioSource audio;
    // Start is called before the first frame update
    void RollSound()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider)
                    audio.PlayOneShot(RollDice);
            }
        
    }

}
