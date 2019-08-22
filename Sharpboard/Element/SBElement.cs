using System.Collections.Generic;
using System;
using Sharpboard.Effect;
using Sharpboard.Command;

namespace Sharpboard.Element {
	public class SBElement {
		public delegate void OnCommandAdded(SBCommand command);
		public event OnCommandAdded CommandAddEvent;
		public delegate void OnCommandChanged(SBCommand command);
		public event OnCommandChanged CommandChangeEvent;
		public delegate void OnCommandRemoved(SBCommand command);
		public event OnCommandRemoved CommandRemoveEvent;

		private Dictionary<Guid, SBCommand> Commands = new Dictionary<Guid, SBCommand>();
		private SBEffect Effect;
		private Guid Id;
		public string Name = "";

		public SBElement(SBEffect effect) {
			Effect = effect;
			Id = Guid.NewGuid();
		}

		public SBCommand GetCommand(Guid id) {
			return Commands.ContainsKey(id) ? Commands[id] : null;
		}

		public SBEffect GetEffect() {
			return Effect;
		}

		public Guid GetId() {
			return Id;
		}

		public void AddCommand(SBCommand command) {
			bool changed = Commands.ContainsKey(command.GetId());
			Commands[command.GetId()] = command;

			if (changed) {
				CommandChangeEvent(command);
			} else {
				CommandAddEvent(command);
			}
		}

		public Dictionary<Guid, SBCommand> GetCommands() {
			return Commands;
		}

		public void RemoveCommand(SBCommand command) {
			if (Commands.Remove(command.GetId())) {
				CommandRemoveEvent(command);
			}
		}

		public void RemoveCommand(Guid id) {
			if (Commands.TryGetValue(id, out SBCommand command)) {
				RemoveCommand(command);
			}
		}

	}
}
