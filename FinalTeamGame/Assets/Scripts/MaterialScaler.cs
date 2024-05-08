using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScaler : MonoBehaviour
{
	public float factor = 1;

	void Update()
	{
		var mf = GetComponent<MeshFilter>();
		if (mf != null)
		{
			var bounds = mf.mesh.bounds;

			var size = Vector3.Scale(bounds.size, transform.localScale) * factor;

			if (size.y < .001)
				size.y = size.z;

			GetComponent<Renderer>().material.mainTextureScale = size;
		}
	}
}

