﻿namespace Contracts.Events;

public class OrderCreated
{
    public int Id { get; set; }
    public Guid OrderId { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal TotalAmount { get; set; }
}