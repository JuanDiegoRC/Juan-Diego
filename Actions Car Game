using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Coche : MonoBehaviour 
{
	public int id;
	
	[SerializeField] float _speed;
	[SerializeField] float _angularSpeed;
	Rigidbody _rigidBody;
	Quaternion startRot;
	float _moveZ;
	float _moveX;
	private Vector3 moveDir = Vector3.zero;

	public float acc;
	public float maxSpeed;
	public float maxSpeed1;
    private Rigidbody rb;

	public string horizontalAxis;
	public string verticalAxis;
    public AudioClip crashHard;   
	public int points;
	public AudioSource source;
	public Text text;
	public GameObject image;
    public GameObject image3;

	private Gamemanager gameManager;
	public float delay;

	private bool stopped;
	
	void Start()
	{
		gameManager = Gamemanager.instance;

		//Declarar la rotación.
		startRot = transform.rotation;
       
		//Asignar el Rigidbody.
		_rigidBody = GetComponent<Rigidbody>();

		if (_rigidBody == null)
		{
			Debug.LogError("Rigid body could noy be found.");
		}

		text.text ="Vidas: " + points + "/5";	
		image.SetActive(false);
		image3.SetActive(false);
		
	} 
	
	
	//PUNTUACIÓN
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "End1")
		{
			LosePoints(1);

            source.time = delay; 
            source.Play();

		}
	}
	public void LosePoints(int newPoints)
	{
		points-=newPoints;
		text.text ="Vidas: " + points + "/5";

		if(points <= 0)
		{
			gameManager.EndGame(id, Gamemanager.VictoryType.death);
		}
       
		
	}
		
	void FixedUpdate ()
	{ 
		if(!stopped)
		{
			//MOVIMIENTO:

			//controles del movimiento.
			_moveX = Input.GetAxis(horizontalAxis);
			_moveZ = Input.GetAxis(verticalAxis);
		
			//Rotación del Rigidbody.
			Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, _angularSpeed, 0) *_moveX);
			_rigidBody.MoveRotation(_rigidBody.rotation * deltaRotation);

			//Límite de velocidad.
			if (_moveZ > 0)
			{
				if (_speed < maxSpeed)
	            	_speed += acc;
			}
			//Desaceleración.
			else if (_moveZ == 0)
			{
				//Alante.
				if(_speed > 0)
					_speed -= acc;
				//Atrás.
				else if(_speed < 0)
					_speed += acc;
			}	

			//Límite hacia atrás.
			else if (_moveZ < 0)
			{
				if (_speed > maxSpeed1)
	            	_speed -= acc;
			}

			//Velocidad del Rigidbody.
			_rigidBody.velocity = transform.TransformDirection(new Vector3(0, _rigidBody.velocity.y, _speed));

		}
	}	

	public void StopCar()
	{
		stopped = true;
	}

	public void StartCar()
	{
		stopped = false;
	}
}	
