﻿using System;
using Obd2Net.Infrastructure.Commands;
using Obd2Net.InfrastructureContracts;
using Obd2Net.InfrastructureContracts.Enums;

namespace Obd2Net.Infrastructure.Response
{
    internal class OBDResponse<T> : IOBDResponse<T>
    {
        internal OBDResponse(IOBDCommand<T> command = null, params IMessage[] messages)
        {
            Command = command;
            Messages = messages ?? new IMessage[0];
        }

        public IOBDCommand<T> Command { get; }
        public IMessage[] Messages { get; }
        public T Value { get; set; }
        public Unit Unit { get; set; }
        public DateTime Time { get; set; }
    }
}