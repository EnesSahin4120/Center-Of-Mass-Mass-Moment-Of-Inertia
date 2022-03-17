using UnityEngine;

public class CenterOfMassTest : MonoBehaviour
{
    public PhysicsBody[] allBodies;

    private void Start()
    {
        Vector3 CenterOfMass = PhysicsOperation.CenterOfMass(allBodies);

        for (int i = 0; i < allBodies.Length; i++)
        {
            Debug.DrawLine(allBodies[i].transform.position, CenterOfMass, Color.red, Mathf.Infinity);
        }
    }
}
