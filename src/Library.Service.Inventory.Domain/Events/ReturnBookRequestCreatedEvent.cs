﻿using Library.Domain.Core;
using Library.Domain.Core.Attributes;
using Library.Domain.Core.Models;
using System;

namespace Library.Service.Inventory.Domain.Events
{
    [EventLog(Code = Code_RETURNBOOKREQUEST_CREATED, Message = "Event Finished.", Type = LogType.Info)]
    [EventLog(Code = Code_SERVER_ERROR, Type = LogType.Error)]
    public class ReturnBookRequestCreatedEvent : DomainEvent
    {
        private static string Event_ReturnBookRequestCreated = "Event_ReturnBookRequestCreated";
        public const string Code_RETURNBOOKREQUEST_CREATED = "RETURNBOOKREQUEST_CREATED";

        public ReturnBookRequestCreatedEvent() : base(Event_ReturnBookRequestCreated)
        {
        }

        public Guid BookInventoryId { get; set; }

        public DateTime ReturnDate { get; set; }

        public PersonName Name { get; set; }
    }
}