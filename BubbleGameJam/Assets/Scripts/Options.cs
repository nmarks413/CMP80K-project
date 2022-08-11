using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Options : MonoBehaviour
{
    private Canvas Main;
    private Canvas OptionsCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Main = GameObject.Find("Main").gameObject.GetComponent<Canvas>();

        Button btn = GameObject.Find("Options").GetComponent<Button>();
        btn.onClick.AddListener(OpenOptions);

        OptionsCanvas = GameObject.Find("OptionsCanvas").GetComponent<Canvas>();
        OptionsCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OpenOptions()
    {
        Main.gameObject.SetActive(false);
        OptionsCanvas.gameObject.SetActive(true);
    }
}
