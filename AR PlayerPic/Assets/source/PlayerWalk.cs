﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour {


    Animator anim;
    bool walk;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
        StartCoroutine(Animate());
    }
	
	// Update is called once per frame
	void Update () {
        if (walk) {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        else 
        {
           // anim.SetTrigger("Stop");
        }
    }

    IEnumerator Animate()
    {
        walk = true;
        yield return new WaitForSeconds(2.5f);
        walk = false;
        anim.SetTrigger("Stop");
    }

}
