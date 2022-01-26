using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class About : MonoBehaviour
{
    bool isAppear = false;
    [SerializeField] GameObject go;
    [SerializeField] Button btn;

    void Start()
    {
       btn = GameObject.Find("Button").GetComponent<Button>();
       btn.onClick.AddListener(delegate
       {
           ShowHideGameObject();
       });
    }

    private void ShowHideGameObject()
    {
        isAppear = !isAppear;

        if (isAppear) go.SetActive(true);
        else go.SetActive(false);
    }
}
