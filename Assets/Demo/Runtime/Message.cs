using System;
using UnityEngine;
using UnityEngine.UI;

namespace vmp1r3.Pottery.Demo
{
	public sealed class Message : MonoBehaviour
	{
		public static Message Instance { get; private set; }

		[SerializeField]
		private Text _message;

		private Action _onClose = delegate { };

		private void Awake()
		{
			Instance = this;
		}

		public void PopUp(string message, Action onClose = null)
		{
			onClose = onClose ?? delegate { };
			CanvasController.Instance.ShowElement(3);
			_message.text = message;
			_onClose = onClose;
		}

		public void Close()
		{
			CanvasController.Instance.Back();
			_message.text = "Null";
			_onClose();
			_onClose = delegate { };
		}
	}
}
