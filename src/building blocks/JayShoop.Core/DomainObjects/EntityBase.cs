using JayShoop.Core.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JayShoop.Core.DomainObjects
{
    public class EntityBase
    {
        [JsonIgnore]
        public ValidationResult? ValidationResult { get; protected set; }

        [JsonIgnore]
        private List<Event>? _notifications;

        [JsonIgnore]
        public IReadOnlyCollection<Event>? Notifications => _notifications?.AsReadOnly();

        public EntityBase()
        {
            Id = Guid.NewGuid();    
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdateAt { get; protected set; }

        public void AddEvent(Event eventItem)
        {
            _notifications = _notifications ?? new List<Event>();
            _notifications.Add(eventItem);
        }

        public void RemoveEvent(Event eventItem)
        {
            _notifications?.Remove(eventItem);
        }

        public void ClearEvents() => _notifications?.Clear();


        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
