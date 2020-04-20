using System.Collections.Generic;
using UnityEngine;

namespace vmp1r3.Pottery.Demo
{
	public sealed class CanvasController : MonoBehaviour
	{
		public static CanvasController Instance { get; private set; }

		[SerializeField]
		private int _startWindow;

		[SerializeField]
		private GameObject[] _windows;
		
		private Stack<int> _history;

		private void Awake()
		{
			_history = new Stack<int>();

			Instance = this;
			
			ShowElement(_startWindow);
		}

		public void ShowElement(int index)
		{
			_history.Push(index);
			foreach (var element in _windows)
				element.SetActive(false);

			_windows[index].SetActive(true);
		}

		public void Back()
		{
			_history.Pop();
			ShowElement(_history.Pop());
		}
	}
}
