using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifebarController : MonoBehaviour
{
    public Image _healthBar;
    public float _healthBarAmount = 100.0f;

    float _damage = 10.0f;
    float _healingAmount = 5.0f;

    private void OnMouseDown() 
    {
        _healthBarAmount -= _damage;
        _healthBar.fillAmount = _healthBarAmount / 100.0f;
    }

    public void Heal()
    {
        _healthBarAmount += _healingAmount;
        _healthBarAmount = Mathf.Clamp(_healthBarAmount, 0, 100);
        _healthBar.fillAmount = _healthBarAmount / 100f;
    }

    
}
