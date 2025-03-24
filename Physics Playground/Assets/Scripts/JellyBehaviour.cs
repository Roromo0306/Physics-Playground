using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyBehaviour : MonoBehaviour
{
    public float Intensidad = 1f;
    public float Masa = 1f;
    public float Dureza = 1f;
    public float Damping = 0.75f;
    private Mesh OriginalMesh, MeshClone;
    private MeshRenderer renderer;
    private JellyVertex[] jelly;
    private Vector3[] vertexArray;

    void Start()
    {
        OriginalMesh = GetComponent<MeshFilter>().sharedMesh;
        MeshClone = Instantiate(OriginalMesh);
        GetComponent<MeshFilter>().sharedMesh = MeshClone;
        renderer = GetComponent<MeshRenderer>();

        jelly = new JellyVertex[MeshClone.vertices.Length];
        for (int i = 0; i < MeshClone.vertices.Length; i++) 
            jelly[i] = new JellyVertex(i, transform.TransformPoint(MeshClone.vertices[i]));
    }

    void FixedUpdate()
    {
        vertexArray = OriginalMesh.vertices;
        for (int i = 0; i < jelly.Length; i++)
        {
            Vector3 Target = transform.TransformPoint(vertexArray[jelly[i].ID]);
            float intensity = (1 - (renderer.bounds.max.y - Target.y) / renderer.bounds.size.y) * Intensidad;
            jelly[i].Shake(Target, Masa, Dureza, Damping);
            Target = transform.InverseTransformPoint(jelly[i].Posicion);
            vertexArray[jelly[i].ID] = Vector3.Lerp(vertexArray[jelly[i].ID], Target, Intensidad);
        }
        MeshClone.vertices = vertexArray;
    }

    public class JellyVertex
    {
        public int ID;
        public Vector3 Posicion;
        public Vector3 Velocidad, Force;
        public Vector3 Target;

        public JellyVertex(int ID, Vector3 Posicion)
        {
            this.ID = ID;
            this.Posicion = Posicion;
        }

        public void Shake(Vector3 Target, float m, float s, float d)
        {
            Force = (Target - Posicion) * s;
            Velocidad = (Velocidad + Force/m) * d;
            Posicion += Velocidad;

            if ((Velocidad + Force + Force).magnitude < 0.001f)
                Posicion = Target;
        }
    }
}

