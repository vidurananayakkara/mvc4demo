namespace Assignment.Demo3.Model.VS2013.Core
{
    public interface IIdentifier
    {
        int Id { get; set; }
        byte[] RowVersion { get; set; }
    }
}
