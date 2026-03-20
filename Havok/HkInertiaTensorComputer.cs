using VRageMath;

namespace Havok {
    public partial class HkInertiaTensorComputer {
        public static HkInertiaTensorComputer Instance { get;  }
        public static HkMassProperties ComputeBoxVolumeMassProperties(Vector3 halfExtents, float mass) => throw new NotImplementedException();
        public static HkMassProperties ComputeCapsuleVolumeMassProperties(Vector3 startAxis, Vector3 endAxis, float radius, float mass) => throw new NotImplementedException();
        public static HkMassProperties ComputeCylinderVolumeMassProperties(Vector3 startAxis, Vector3 endAxis, float radius, float mass) => throw new NotImplementedException();
        public static HkMassProperties ComputeSphereVolumeMassProperties(float radius, float mass) => throw new NotImplementedException();
        public static void CombineMassProperties(Span<HkMassElement> elements, ref HkMassProperties massProperties) => throw new NotImplementedException();
        public HkInertiaTensorComputer() { /* Initialize Jolt Equivalent Here */ }
    }
}
