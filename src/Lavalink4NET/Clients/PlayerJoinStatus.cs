﻿namespace Lavalink4NET.Clients;

public enum PlayerJoinStatus : byte
{
    Success,
    UserNotInVoiceChannel,
    VoiceChannelMismatch,
    BotNotConnected,
}
