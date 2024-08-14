using CoreLayer.Utilities.Results.Abstract;

namespace CoreLayer.Utilities.Results.Concrete;

public class DataResult<P> : Result, IDataResult<P>
{
    public DataResult(int data, bool success, string message) : base(success, message)
    {
        Data = data;
    }

    public DataResult(int data, bool success) : base(success)
    {
        Data = data;
    }

    public int Data { get; }
}