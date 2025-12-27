namespace BusinessLogic.Interface
{
    public interface IImageService
    {
        Task<string?> UploadAsync(
            Stream stream,
            string fileName
        );
    }
}
