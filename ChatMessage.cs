using Penguin.Cms.Entities;
using System;

namespace Penguin.Cms.Communication
{
    public class ChatMessage : Entity
    {
        public Guid ChatSession { get; set; }

        public string Contents { get; set; } = string.Empty;

        public string DisplayName { get; set; } = string.Empty;

        public Guid User { get; set; }
    }
}