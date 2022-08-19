using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Loader")
        {
            if (PlayerPrefs.GetString("savedGameState") == "Wake Up")
            {
                SceneManager.LoadScene("demoHome", LoadSceneMode.Single);
            }
            else if (PlayerPrefs.GetString("savedGameState") == "School Hallway")
            {
                SceneManager.LoadScene("demoScene", LoadSceneMode.Single);
            }
            else if (PlayerPrefs.GetString("savedGameState") == "Class")
            {
                SceneManager.LoadScene("demoClassroom", LoadSceneMode.Single);
            }
        }
    }
}
