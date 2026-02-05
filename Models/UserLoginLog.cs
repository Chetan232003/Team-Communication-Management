using System.ComponentModel.DataAnnotations.Schema;

namespace TeamCommunicationPlatform.Models
{
    public class UserLoginLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
    }
}
