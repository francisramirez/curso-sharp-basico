

namespace MiApp
{
    public class ImporteException : Exception
    {
        public ImporteException(string message): base(message)
        {
            SaveData(message);
        }
        void SaveData(string message) 
        {
            // Guardando el error //
        }
    }
}
