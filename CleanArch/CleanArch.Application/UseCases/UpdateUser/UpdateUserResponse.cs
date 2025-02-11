namespace CleanArch.Application.UseCases.UpdateUser
{
    public sealed record UpdateUserResponse
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Email { get; }
    }
}