﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 水 : MonoBehaviour {
    public float SPAWN_INTERVAL = 1f; // How much time until the next particle spawns
    public float lastSpawnTime = float.MinValue; //The last spawn time
    public int PARTICLE_LIFETIME = 3; //How much time will each particle live
    public Vector3 particleForce; //Is there a initial force particles should have?
    public DynamicParticle.STATES particlesState = DynamicParticle.STATES.WATER; // The state of the particles spawned
    public Transform particlesParent; // Where will the spawned particles will be parented (To avoid covering the whole inspector with them)
    public GameObject zzzzzzzzz;                         // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (lastSpawnTime + SPAWN_INTERVAL < Time.time)
        { // Is it time already for spawning a new particle?
            GameObject newLiquidParticle = (GameObject)Instantiate(zzzzzzzzz); //Spawn a particle
            newLiquidParticle.GetComponent<Rigidbody2D>().AddForce(particleForce); //Add our custom force
            DynamicParticle particleScript = newLiquidParticle.GetComponent<DynamicParticle>(); // Get the particle script
            particleScript.SetLifeTime(PARTICLE_LIFETIME); //Set each particle lifetime
            particleScript.SetState(particlesState); //Set the particle State
            newLiquidParticle.transform.position = transform.position;// Relocate to the spawner position
            newLiquidParticle.transform.parent = particlesParent;// Add the particle to the parent container		
            newLiquidParticle.transform.localScale = new Vector3(10, 10, 10);
            lastSpawnTime = Time.time; // Register the last spawnTime			
        }
    }
}
