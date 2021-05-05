using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Life : MonoBehaviour
{
    public GameObject[] lifeImages;
    private int currentLife;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = lifeImages.Length;
    }

    // Update is called once per frame
   public void DecreaseLife()
    {
        currentLife--;

        lifeImages[currentLife].SetActive(false);

        if (currentLife == 0) {
            SceneManager.LoadScene("GameOver");
        }
    }
}
