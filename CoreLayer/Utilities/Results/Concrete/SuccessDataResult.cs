namespace CoreLayer.Utilities.Results.Concrete;

public class SuccessDataResult<P> : DataResult<P>
{
    public SuccessDataResult(int data) : base(data, true)
    {
    }

    public SuccessDataResult(int data, string message) : base(data, true, message)
    {
    }

    public SuccessDataResult() : base(default, true)
    {
    }

    public SuccessDataResult(string message) : base(default, true, message)
    {
    }
}