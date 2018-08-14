using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertexDebugger : MonoBehaviour
{
    private void OnDrawGizmosSelected()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;

        Gizmos.color = Color.blue;

        foreach (var vert in mesh.vertices)
        {
            Gizmos.DrawSphere(transform.TransformPoint(vert), 0.1f);
        }
    }

}
