using UnityEngine;

namespace vmp1r3.Pottery.Demo
{
	public sealed class RotateAround : MonoBehaviour
	{
		[SerializeField]
		private float _speed;

		private void Update()
		{
			transform.Rotate(Time.deltaTime * _speed * Vector3.up);
		}
	}
}