using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMEUI : MonoBehaviour
{
    public TMP_Text scoretext;
    // Start is called before the first frame update
    int score;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

   public void resetS()
    {
        score=0;
		scoretext.text = score.ToString();
	}

	public void Addscore()
    {
        score++;
		scoretext.text = score.ToString();
	}
}
