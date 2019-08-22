using System.Collections.Generic;
using System;
using Sharpboard.Element;

namespace Sharpboard.Effect {
	public class SBEffect {
		public delegate void OnElementAdded(SBElement element);
		public event OnElementAdded ElementAddEvent;
		public delegate void OnElementChanged(SBElement element);
		public event OnElementChanged ElementChangeEvent;
		public delegate void OnElementRemoved(SBElement element);
		public event OnElementRemoved ElementRemoveEvent;

		public string Name;
		private Guid Id;
		private Storyboard Storyboard;
		private Dictionary<Guid, SBElement> Elements = new Dictionary<Guid, SBElement>();

		public SBEffect(Storyboard storyboard) {
			Storyboard = storyboard;
			Id = Guid.NewGuid();
		}

		public Guid GetId() {
			return Id;
		}

		public Storyboard GetStoryboard() {
			return Storyboard;
		}

		public SBElement GetElement(Guid id) {
			return Elements.ContainsKey(id) ? Elements[id] : null;
		}

		public Dictionary<Guid, SBElement> GetElements() {
			return Elements;
		}

		public void AddElement(SBElement element) {
			bool changed = Elements.ContainsKey(element.GetId());
			Elements[element.GetId()] = element;
			
			if (changed) {
				ElementChangeEvent(element);
			} else {
				ElementAddEvent(element);
			}
		}

		public void RemoveElement(SBElement element) {
			if (Elements.Remove(element.GetId())) {
				ElementRemoveEvent(element);
			}
		}

		public void RemoveElement(Guid id) {
			if (Elements.TryGetValue(id, out SBElement element)) {
				RemoveElement(element);
			}
		}
	}
}
