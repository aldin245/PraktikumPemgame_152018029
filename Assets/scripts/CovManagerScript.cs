using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CovManagerScript : MonoBehaviour
{
    bool isAppear = false;
    [SerializeField] GameObject go;
    [SerializeField] Button btn;

    void Start()
    {
       btn = GameObject.Find("About Button").GetComponent<Button>();
       btn.onClick.AddListener(delegate
       {
           ShowHideGameObject();
       });

       go = GameObject.Find("About");
    }

    private void ShowHideGameObject()
    {
        isAppear = !isAppear;

        //if (isAppear) go.SetActive(true);
        //else go.SetActive(false);

        if (isAppear) ActivatingLean();
        else OffLean();
    }

    private void ActivatingLean()
    {
        go.transform.LeanMoveLocalY(0, 1f).setEase(LeanTweenType.easeInOutExpo);
    }

    private void OffLean()
    {
         go.transform.LeanMoveLocalY(-2486, 1f);
    }
}
