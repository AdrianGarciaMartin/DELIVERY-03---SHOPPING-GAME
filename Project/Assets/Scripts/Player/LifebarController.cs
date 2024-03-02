using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifebarController : MonoBehaviour
{
    public Image _healthBar;
    public float _healthBarAmount = 100.0f;
    public SceneLoader _sceneLoader;

    float _damage = 10.0f;
    float _healingAmount = 5.0f;

    private void Update()
    {
        if (IsDead()) Die();
    }

    private void OnMouseDown() 
    {
        _healthBarAmount -= _damage;
        _healthBar.fillAmount = _healthBarAmount / 100.0f;
        Debug.Log(_healthBarAmount);
    }

    public void Heal()
    {
        _healthBarAmount += _healingAmount;
        _healthBarAmount = Mathf.Clamp(_healthBarAmount, 0, 100);
        _healthBar.fillAmount = _healthBarAmount / 100f;
    }

    private bool IsDead()
    {
        return _healthBarAmount <= 0;
    }

    public void Die()
    {
        _sceneLoader.EnterExitScene();
    }
}
