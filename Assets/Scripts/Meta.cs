using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{

    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;

    private bool _isInMeta;

    public RectTransform NextLevel;
    public GameObject hordes;

    private Animator _animator;
    private PlayerController _controller;
    // Update is called once per frame

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _controller = GetComponent<PlayerController>();
    }

    void Update()
    {
        _isInMeta = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        if (_isInMeta)
        {
            NextLevel.gameObject.SetActive(true);
            hordes.SetActive(false);
            _animator.enabled = false;
            _controller.enabled = false;
        }
    }
}
