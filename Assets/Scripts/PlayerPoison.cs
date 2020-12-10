using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPoison : MonoBehaviour
{
	public int totalPoison = 0;
	public RectTransform PoisonUI;
	public Transform startPoint;

	//Game Over
	public RectTransform GameOverMenu;
	private int poison;
	private float poisonSize = 16f;

	private SpriteRenderer _renderer;
	private Animator _animator;
	private PlayerController _controller;


	private void Awake()
	{
		_renderer = GetComponent<SpriteRenderer>();
		_animator = GetComponent<Animator>();
		_controller = GetComponent<PlayerController>();
	}

	void Start()
	{
		poison = totalPoison;
	}

	public void AddPoison(int amount)
	{
		poison = poison + amount;

		PoisonUI.sizeDelta = new Vector2(poisonSize * poison, poisonSize);

		Debug.Log("Player got some poison. His current poison is " + poison);
	}

	private IEnumerator VisualFeedback()
	{
		_renderer.color = Color.red;

		yield return new WaitForSeconds(0.1f);

		_renderer.color = Color.white;
	}

	private void OnEnable()
	{
		/* gameObject.SetActive(true);  */
		poison = totalPoison;
		transform.position = new Vector2(startPoint.transform.position.x, startPoint.transform.position.y);
	}

	private void OnDisable()
	{
		GameOverMenu.gameObject.SetActive(true);
		_animator.enabled = false;
		_controller.enabled = false;
	}
}
