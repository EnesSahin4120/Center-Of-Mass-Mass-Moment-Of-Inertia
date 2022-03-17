using UnityEngine;

public class Rectangular : PhysicsBody
{
    public float width;
    public float height;
    public float length;
 
    public override Vector3 InertiaTensor
    {
        get
        {
            float x = width;
            float y = height;
            float z = length;
            float m = mass;

            float[,] inertiaTensorElements = { { m * (y * y + z * z)  ,  -m * x * y ,  -m * x * z },
                                             { -m * x * y  ,  m * (x * x + z * z) ,  -m * y * z },
                                             { -m * x * z  ,  -m * y * z ,  m * (x * x + y * y) }
            };
            Vector3 result = new Vector3(1 / 12f * inertiaTensorElements[0, 0], 1 / 12f * inertiaTensorElements[1, 1], 1 / 12f * inertiaTensorElements[2, 2]);
            return result;
        }
    }

    public override Vector3 CenterOfMass => base.CenterOfMass;

    public override float Weight => base.Weight;
}
