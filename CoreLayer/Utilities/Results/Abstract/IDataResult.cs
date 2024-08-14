namespace CoreLayer.Utilities.Results.Abstract;

public interface IDataResult<P> : IResult
{
    int Data { get; }
}