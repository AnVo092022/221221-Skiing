using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    public float delay = 0.5f;
    [SerializeField]
    ParticleSystem particle;

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Terrain")
        {
            particle.Play();
            Invoke("RestartGame", delay);
        }
    }

    void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
