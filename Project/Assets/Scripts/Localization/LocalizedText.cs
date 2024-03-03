using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocalizedText : MonoBehaviour
{
    public string _textKey;
    private TextMeshProUGUI _textValue;
    //private TMP_Text _textValue;

    void Start()
    {
        _textValue = GetComponent<TextMeshProUGUI>();
        //_textValue = GetComponent<TMP_Text>();
        SetText();

        Debug.Log(_textKey);
    }

    private void OnEnable()
    {
        Localizer.OnLanguageChangeDelegate += OnLanguageChanged;
    }

    private void OnDisable()
    {
        Localizer.OnLanguageChangeDelegate -= OnLanguageChanged;
    }

    private void OnLanguageChanged()
    {
        SetText();
    }

    private void SetText()
    {
        _textValue.text = Localizer.GetText(_textKey);
    }
}
