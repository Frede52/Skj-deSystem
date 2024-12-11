﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Core
{
    public class Apartment
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId ApartmentId { get; set; }

        public string Address { get; set; }

        public string Status { get; set; } = "Ikke Fuldført";

        public Tenant Tenant { get; set; }

        public bool IsComplete { get; set; } = false;

        public List<Availability> Availability { get; set; }
    }
}