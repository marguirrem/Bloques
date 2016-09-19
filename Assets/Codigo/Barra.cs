using UnityEngine;
using System.Collections;

public class Barra : MonoBehaviour {
	
	public float velocidad = 5;
	Vector3 posicionInicial;
	// Use this for initialization
	void Start () {
		Debug.Log ("Start");
		posicionInicial = transform.position;
	}

	public void Reset(){
		transform.position = posicionInicial;

	}
	
	// Update is called once per frame
	void Update () {
		float tecaldoX = Input.GetAxisRaw ("Horizontal");
		float posX = transform.position.x + (tecaldoX * velocidad * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(posX,-8,8),transform.position.y,transform.position.z);

		
		Debug.Log ("x= "+posX);
	}
}
