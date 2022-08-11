using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    // Start is called before the first frame update
    private Canvas Main;
    private Canvas OptionsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Main = GameObject.Find("Main").GetComponent<Canvas>();

        Button btn = GameObject.Find("Back").GetComponent<Button>();
        btn.onClick.AddListener(OpenOptions);

        OptionsCanvas = GameObject.Find("OptionsCanvas").GetComponent<Canvas>();
    }

    void OpenOptions()
    {
        Main.gameObject.SetActive(true);
        OptionsCanvas.gameObject.SetActive(false);
    }
}
