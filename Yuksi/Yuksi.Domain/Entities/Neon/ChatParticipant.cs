using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class ChatParticipant
{
    public Guid Id { get; set; }

    public Guid? ChatId { get; set; }

    public Guid UserId { get; set; }

    public string UserType { get; set; } = null!;

    public DateTime? JoinedAt { get; set; }

    public virtual Chat? Chat { get; set; }
}
