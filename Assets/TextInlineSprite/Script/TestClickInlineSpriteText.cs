﻿using UnityEngine;
using System.Collections;

public class TestClickInlineSpriteText : MonoBehaviour {
    private InlieSpriteText _text;
    
    void Awake()
    {
        _text = GetComponent<InlieSpriteText>();
    }

    void OnEnable()
    {
        _text.onHrefClick.AddListener(OnHrefClick);
    }

    void OnDisable()
    {
        _text.onHrefClick.RemoveListener(OnHrefClick);
    }

    private void OnHrefClick(string hrefName)
    {
        Debug.Log("点击了 " + hrefName);
      //  Application.OpenURL("www.baidu.com");
    }
}
