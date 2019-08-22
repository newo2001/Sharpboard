using System;
using System.Collections.Generic;
using Sharpboard.Effect;

namespace Sharpboard {
	public class Storyboard {
		public delegate void OnEffectAdded(SBEffect effect);
		public event OnEffectAdded EffectAddEvent;
		public delegate void OnEffectChanged(SBEffect effect);
		public event OnEffectChanged EffectChangeEvent;
		public delegate void OnEffectRemoved(SBEffect effect);
		public event OnEffectRemoved EffectRemoveEvent;

		private Dictionary<Guid, SBEffect> Effects = new Dictionary<Guid, SBEffect>();

		public Dictionary<Guid, SBEffect> GetEffects() {
			return Effects;
		}

		public SBEffect GetEffect(Guid id) {
			return Effects.ContainsKey(id) ? Effects[id] : null;
		}

		public void AddEffect(SBEffect effect) {
			bool changed = Effects.ContainsKey(effect.GetId());
			Effects[effect.GetId()] = effect;

			if (changed) {
				EffectChangeEvent(effect);
			} else {
				EffectAddEvent(effect);
			}
		}

		public void RemoveEffect(SBEffect effect) {
			if (Effects.Remove(effect.GetId())) {
				EffectRemoveEvent(effect);
			}
		}

		public void RemoveEffect(Guid id) {
			if (Effects.TryGetValue(id, out SBEffect effect)) {
				RemoveEffect(effect);
			}
		}
	}
}
