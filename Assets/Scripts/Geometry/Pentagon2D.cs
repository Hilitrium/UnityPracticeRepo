using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pentagon2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var filter = GetComponent<MeshFilter>();
        var mesh = new Mesh();
        filter.mesh = mesh;

        var Verts = new Vector3[5];

        Verts[0] = new Vector3(0, 3, 0);
        Verts[1] = new Vector3(3, 1, 0);
        Verts[2] = new Vector3(2, -2, 0);
        Verts[3] = new Vector3(-2, -2, 0);
        Verts[4] = new Vector3(-3, 1, 0);

        mesh.vertices = Verts;

        var indices = new int[9];

        indices[0] = 0;
        indices[1] = 1;
        indices[2] = 2;
        indices[3] = 2;
        indices[4] = 3;
        indices[5] = 0;
        indices[6] = 3;
        indices[7] = 4;
        indices[8] = 0;

        mesh.triangles = indices;

        var norms = new Vector3[5];

        norms[0] = -Vector3.forward;
        norms[1] = -Vector3.forward;
        norms[2] = -Vector3.forward;
        norms[3] = -Vector3.forward;
        norms[4] = -Vector3.forward;

        mesh.normals = norms;

        var UVs = new Vector2[5];

        UVs[0] = new Vector2(0, 3);
        UVs[1] = new Vector2(3, 1);
        UVs[2] = new Vector2(2, -2);
        UVs[3] = new Vector2(-2, -2);
        UVs[4] = new Vector2(0, -3);

        mesh.uv = UVs;
    }
}
