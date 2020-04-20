using UnityEngine;

namespace vmp1r3.Pottery
{
	/// <summary>
	/// Mesh vertex.
	/// </summary>
	public struct Vertex
	{
		/// <summary>
		/// Mesh vertex.
		/// </summary>
		public Vertex(Vector3 position, Vector3 normal, int index)
		{
			this.position = position;
			this.normal = normal;
			this.index = index;
		}

		/// <summary>
		/// Vertex position in space.
		/// </summary>
		public Vector3 position;

		/// <summary>
		/// Vertex normal.
		/// </summary>
		public Vector3 normal;

		/// <summary>
		/// Index in mesh.
		/// </summary>
		public int index;
	}
}