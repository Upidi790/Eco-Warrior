using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBattle : MonoBehaviour
{

    [SerializeField] public string sceneToLoad;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Destroy(GameObject.Find("Enemy"));
            SceneManager.LoadScene(sceneToLoad);
            //LoadBattleScreen ();
        }
    }

    void LoadBattleScreen()
    {
        //GameController.control.inBattle = true;
        Destroy(GameObject.Find("Enemy"));
        //GameController.control.playerDead = true;
        SceneManager.LoadScene(sceneToLoad);
    }
}