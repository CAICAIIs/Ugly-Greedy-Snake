using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    public Collider2D foodarea;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnTriggerEnter2D(Collider2D collision)
	{
        
        transform.position=new Vector3(
            Random.Range(foodarea.bounds.min.x, foodarea.bounds.max.x),
            Random.Range(foodarea.bounds.min.y, foodarea.bounds.max.y),0);
	}
}
