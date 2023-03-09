using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingLevel : MonoBehaviour
{
    [SerializeField]
    public string levelname;

    int playerInTrigger = 0;

    private void OnTriggerEnter2D(Collider2D pCollision)
    {
        if (pCollision.gameObject.CompareTag("Player"))
        {
            playerInTrigger++;
        }

        if (playerInTrigger >= 2)
        {
            SceneManager.LoadScene(levelname);
        }
    }

    private void OnTriggerExit2D(Collider2D pCollision)
    {
        if (pCollision.gameObject.CompareTag("Player"))
        {
            playerInTrigger--;
        }
    }
}