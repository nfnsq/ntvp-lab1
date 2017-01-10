namespace SalaryRateModel
{
    public struct Parameter
    {
        private double _value;
        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
        private string _description;
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
