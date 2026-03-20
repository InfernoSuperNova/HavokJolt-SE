namespace Havok {
    public partial class RagdollBone {
        public int m_rigidBodyIndex;
        public RagdollBone m_parent;
        public List<RagdollBone> m_children;
        public RagdollBone(HkRigidBody rigidBody) { /* Initialize Jolt Equivalent Here */ }
    }
}
