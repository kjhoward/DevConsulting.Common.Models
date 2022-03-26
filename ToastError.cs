namespace DevConsulting.Common.Models{
    public static class ToastError{
        public static EventHandler<MessageResponse> MessageChanged;
        private static MessageResponse _message;
        public static MessageResponse Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    MessageChanged?.Invoke(typeof(ToastError), _message);
                }
            }
        }
    }
}