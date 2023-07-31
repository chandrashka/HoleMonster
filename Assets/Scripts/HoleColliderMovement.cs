using UnityEngine;

public class HoleColliderMovement : MonoBehaviour
{
    [SerializeField] private PolygonCollider2D holePolygonCollider2D;
    [SerializeField] private PolygonCollider2D groundPolygonCollider2D;
    [SerializeField] private MeshCollider generatedMeshCollider;
    [SerializeField] private float initialScale = 2f;
    private Mesh generatedMesh;

    private void FixedUpdate()
    {
        if (!transform.hasChanged) return;
        
        var holeTransform = transform;
        holeTransform.hasChanged = false;
        
        var holePosition = holeTransform.position;
        var holePolygonCollider2DTransform = holePolygonCollider2D.transform;
        
        holePolygonCollider2DTransform.position = new Vector2(holePosition.x, holePosition.z);
        holePolygonCollider2DTransform.localScale = holeTransform.localScale * initialScale;
        
        MakeHole2D();
        Mesh3DCollider();
    }

    private void MakeHole2D()
    {
        var pointPositions = holePolygonCollider2D.GetPath(0);
        for (var i = 0; i <pointPositions.Length ; i++)
        {
            pointPositions[i] = holePolygonCollider2D.transform.TransformPoint(pointPositions[i]);
        }

        groundPolygonCollider2D.pathCount = 2;
        groundPolygonCollider2D.SetPath(1, pointPositions);
    }

    private void Mesh3DCollider()
    {
        if(generatedMesh != null) Destroy(generatedMesh);
        generatedMesh = groundPolygonCollider2D.CreateMesh(true, true);
        generatedMeshCollider.sharedMesh = generatedMesh;
    }
    
    
}
