using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particle;

    public float delay = 0.5f;
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Player")
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
