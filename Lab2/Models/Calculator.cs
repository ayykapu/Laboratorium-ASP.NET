namespace Lab2.Models
{
    public class Calculator
    {
        public enum Operators
        {
            ADD, SUB, MUL, DIV
        }
        public Operators? op { get; set; }
        public double? X { get; set; }
        public double? Z { get; set; }

        public String OpFix
        {
            get
            {
                switch (op)
                {
                    case Operators.ADD:
                        return "+";
                    case Operators.SUB:
                        return "-";
                    case Operators.MUL:
                        return "*";
                    case Operators.DIV:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid()
        {
            return op != null && X != null && Z != null;
        }

        public double Calculate()
        {
            switch (op)
            {
                case Operators.ADD:
                    return (double)(X + Z);
                case Operators.SUB
                :
                    return (double)(X - Z);
                case Operators.MUL:
                    return (double)(X * Z);
                case Operators.DIV:
                    return (double)(X / Z);
                default: return double.NaN;
            }
        }
    }
}