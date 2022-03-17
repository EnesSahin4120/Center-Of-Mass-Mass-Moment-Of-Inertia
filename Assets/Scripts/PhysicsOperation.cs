using UnityEngine;

public class PhysicsOperation : MonoBehaviour
{

    public static Vector3 MassMomentOfInertia(PhysicsBody rotatingBody, PhysicsBody pivotBody)
    {
        PhysicsBody[] bodies = { rotatingBody, pivotBody };

        float centerX = CenterOfMass(bodies).x;
        float centerY = CenterOfMass(bodies).y;
        float centerZ = CenterOfMass(bodies).z;

        float d2 = Mathf.Pow(rotatingBody.CenterOfMass.x - centerX, 2) + 
                   Mathf.Pow(rotatingBody.CenterOfMass.y - centerY, 2) + 
                   Mathf.Pow(rotatingBody.CenterOfMass.z - centerZ, 2);

        Vector3 result = new Vector3(rotatingBody.InertiaTensor.x + rotatingBody.mass * d2,
                                     rotatingBody.InertiaTensor.y + rotatingBody.mass * d2,
                                     rotatingBody.InertiaTensor.z + rotatingBody.mass * d2);

        return result;
    }

    public static Vector3 CenterOfMass(PhysicsBody[] bodies)
    {
        float totalMass = 0;
        float total_XM = 0;
        float total_YM = 0;
        float total_ZM = 0;

        for (int i = 0; i < bodies.Length; i++)
        {
            totalMass += bodies[i].Weight;
            total_XM += bodies[i].CenterOfMass.x * bodies[i].Weight;
            total_YM += bodies[i].CenterOfMass.y * bodies[i].Weight;
            total_ZM += bodies[i].CenterOfMass.z * bodies[i].Weight;
        }

        Vector3 result = new Vector3(total_XM / (float)totalMass, total_YM / (float)totalMass, total_ZM / (float)totalMass);
        return result;
    }
}
