using System.Runtime.CompilerServices;

namespace TaskManager.Data.Models
{
    public class Attachment
    {
        public int AttachmentID { get; set; }
        public int TaskID { get; set; }
        public string FileName { get; set; }
        public string BlobPath { get; set; }
        public int Size { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}