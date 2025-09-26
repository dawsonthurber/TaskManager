namespace TaskManager.Data.Models
{
    public class Attachment
    {
        public int AttachmentID { get; set; }
        public int TaskID { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string BlobPath { get; set; } = string.Empty;
        public int Size { get; set; }
        public DateTime UploadedAt { get; set; }
    }
}