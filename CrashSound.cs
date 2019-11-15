using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour 
{
	public AudioClip crashHard;   
	public AudioSource source;
    private float lowPitchRange = .75F;
    private float highPitchRange = 1.5F;
    private float velToVol = .2F;
    private float velocityClipSplit = 10F;

    public float delay;



	// Use this for initialization
	void Start () 
	{

	} 
	void Awake () 
	{
        source = GetComponent<AudioSource>();
    }


    void OnCollisionEnter (Collision coll)
    {
        source.pitch = Random.Range (lowPitchRange,highPitchRange);
        float hitVol = coll.relativeVelocity.magnitude * velToVol;
        if (coll.relativeVelocity.magnitude < velocityClipSplit)
            source.PlayOneShot(crashHard,hitVol);
             source.time = delay;
            
    }
}
