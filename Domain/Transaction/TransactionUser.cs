namespace Domain.Transaction;

public class TransactionUser
{
    public required string Id { get; set; }
    public required string Identifier { get; set; }
    public required string Username { get; set; }
    public required string FullName { get; set; }
    public required string Role { get; set; }
}