﻿namespace Finlyze.Domain.Entity;

public abstract class Entity
{
    public Guid Id { get; set; }

    protected Entity()
    {
        Id = Guid.NewGuid();
    }
}