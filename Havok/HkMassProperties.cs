using System.Runtime.InteropServices;
using VRageMath;

namespace Havok {
    [StructLayout(LayoutKind.Sequential)]
    public struct HkMassProperties {
        public float Volume;
        public float Mass;
        public Vector3 CenterOfMass;
        public Matrix InertiaTensor;
        public HkMassProperties(float volume, float mass, Vector3 centerOfMass, Matrix inertiaTensor) { /* Initialize Jolt Equivalent Here */ }
    }
}
