namespace Lesson2
{
    public class OperationResult
    {
        public bool Success { get; set; }
        public string Massage {  get; set; }
        public int Amount {  get; set; }

        private OperationResult(bool success, string massage, int amount)
        {
            Success = success;
            Massage = massage;
            Amount = amount;
        }

        public static OperationResult OK(int amount) { 
        return new OperationResult(true, "Operation succeseded", amount);
        }

    }