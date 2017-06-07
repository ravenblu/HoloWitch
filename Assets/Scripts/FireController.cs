using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour {

	public ParticleSystem[] ps;
	public float rate;

	public void IncreaseFire() {
		for(int i = 0; i<ps.Length; i++) {
			print(ps.Length);
			var emi = ps[i].emission;
			emi.rateOverTime =+ rate;
		}
	}

	public void DecreaseFire() {
		for(int i = 0; i<ps.Length; i++) {
			var emi = ps[i].emission;
			emi.rateOverTime =- rate;
		}
	}


}
