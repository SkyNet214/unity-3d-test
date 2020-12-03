using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject grenadePrefab;
    void Reload()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }

    void increaseExplosionForce(bool withLShift, bool withAltGr)
    {
        int multiplier = 1;
        if (withLShift)
        {
            if (withAltGr)
            {
                multiplier = 100;
            } else
            {
                multiplier = 10;
            }
        }
        grenadePrefab.GetComponent<Explosion>().explosionForce += 10 * multiplier;
    }

    void decreaseExplosionForce(bool withLShift, bool withAltGr)
    {
        int multiplier = 1;
        if (withLShift)
        {
            if (withAltGr)
            {
                multiplier = 100;
            }
            else
            {
                multiplier = 10;
            }
        }
        grenadePrefab.GetComponent<Explosion>().explosionForce -= 10 * multiplier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            Reload();
        }

        if (Input.GetKeyDown("n"))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else if (!isPaused)
            {
                PauseGame();
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            increaseExplosionForce(Input.GetKey(KeyCode.RightShift), Input.GetKey(KeyCode.AltGr));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            decreaseExplosionForce(Input.GetKey(KeyCode.RightShift), Input.GetKey(KeyCode.AltGr));
        }
    }
}
