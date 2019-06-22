namespace Pacco.Services.Parcels.Core.Exceptions
{
    public class InvalidAggregateIdException : ExceptionBase
    {
        public override string Code => "invalid_aggregate_id";
        
        public InvalidAggregateIdException() : base($"Invalid aggregate id.")
        {
        }
    }
}