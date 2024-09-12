using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
	
	public GAMEUI gameUI;

	public Transform body;

	public List<Transform> bodies = new List<Transform>();

	Vector3 diration = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
		
		Time.timeScale = 0.2f;
		Reseta();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, 1,0);
			diration = Vector3.up;
        }
		if (Input.GetKeyDown(KeyCode.S))
		{
			transform.Translate(0, -1, 0);
			diration = Vector3.down;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			transform.Translate(-1, 0, 0);
			diration = Vector3.left;
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			transform.Translate(1, 0, 0);
			diration = Vector3.right;
		}
		
	}
	private void FixedUpdate()
	{

		for (int i = bodies.Count - 1; i > 0; i--)
		{
			bodies[i].position=bodies[i-1].position;
		}
		transform.Translate(diration);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("food"))
		{
			bodies.Add(Instantiate(body,transform.position,Quaternion.identity));
			gameUI.Addscore();
		}
		if (collision.CompareTag("walls"))
		{
			Debug.Log("GAME OVER!");
			Reseta();
		}
		
	}

	private void Reseta()
	{
		transform.position = Vector3.zero;
		diration = Vector3.zero;
		for (int i = 1; i < bodies.Count; i++)
		{
			Destroy(bodies[i].gameObject);
		}
		bodies.Clear();
		bodies.Add(transform);

		gameUI.resetS();
	}
}
