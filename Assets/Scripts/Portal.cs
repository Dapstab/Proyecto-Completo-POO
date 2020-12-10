using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Portal : MonoBehaviour
{
    public RectTransform NextLevelMenu;
    private Animator _animator;
    private PlayerController _controller;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Congrats!! ");
            NextLevelMenu.gameObject.SetActive(true);
            _animator.enabled = false;
            _controller.enabled = false;
        }
    }
}