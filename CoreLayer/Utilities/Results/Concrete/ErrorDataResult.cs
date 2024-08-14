namespace CoreLayer.Utilities.Results.Concrete;

public class ErrorDataResult<P> : DataResult<P>
{
    public ErrorDataResult(int data, string message) : base(data, false, message)
    {
    }

    public ErrorDataResult(int data) : base(data, false)
    {
    }

    public ErrorDataResult(string message) : base(default, false, message)
    {
    }

    public ErrorDataResult() : base(default, false)
    {
    }
}