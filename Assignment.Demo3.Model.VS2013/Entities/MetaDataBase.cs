using System.ComponentModel.DataAnnotations;
using Assignment.Demo3.Model.VS2013.Core;

namespace Assignment.Demo3.Model.VS2013.Entities
{
    public class MetaDataBase : IIdentifier
    {
        public int Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
