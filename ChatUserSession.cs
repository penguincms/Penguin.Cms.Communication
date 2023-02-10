using Penguin.Cms.Entities;
using System;

namespace Penguin.Cms.Communication
{
    public class ChatUserSession : Entity
    {
        public Guid ChatSession { get; set; }

        public Guid User { get; set; }
    }
}