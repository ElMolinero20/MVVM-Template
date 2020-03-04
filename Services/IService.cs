namespace MVVM.Services.Locator
{
    public interface IService
    {
        /// <summary>
        /// A property that holds the name of the service.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// A property that holds the ID of the service.
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Executes the service.
        /// </summary>
        void Execute();
    }
}
