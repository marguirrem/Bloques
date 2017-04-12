using UnityEngine;
using System.Collections;

public class Pelota : MonoBehaviour {

	public Rigidbody rigid;

	public 	float 	velocidadInicial 	= 600f;
	public 	bool 	enJuego 			= false;
	public 	Transform 	barra;
	Vector3 posicionInicial;


	// Use this for initialization
	void Start () {
		posicionInicial = transform.position;
	}

	public void Reset(){
		transform.position 	= posicionInicial;
		transform.SetParent (barra);
		enJuego = false;
		rigid.isKinematic  	= true;
		rigid.velocity 		= Vector3.zero;
	}

	public void detenerMovimiento(){
		rigid.isKinematic 	= true;
		rigid.velocity 		= Vector3.zero;
	}

	// Update is called once per frame
	void Update () {
		if(!enJuego && Input.GetButtonDown("Fire1")){
			enJuego = true;
			transform.SetParent (null);
			rigid.isKinematic = false;
			rigid.AddForce (new Vector3(velocidadInicial,velocidadInicial,0));
		}
	}
}
