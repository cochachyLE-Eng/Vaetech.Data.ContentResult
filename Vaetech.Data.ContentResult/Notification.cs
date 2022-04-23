using System.Linq;
/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!
* Owners: Liiksoft
* Create by Luis Eduardo Cochachi Chamorro
* License: MIT or Apache-2.0
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~!*/
namespace Vaetech.Data.ContentResult
{
    public class Notification<T> : ActionResult
    {
        public double Porcent { get; private set; } = 0;
        public int Lines { get; set; } = 0;
        public int Row { get; set; } = 0;
        public int Column { get; set; } = 0;
        public int Level { get; set; } = 1;
        public T Value { get; set; }
        public double SetPorcent(int lines, int rowIndex)
        {
            if (lines == 0) return 0;
            Lines = lines; Row = rowIndex;
            return Porcent = (rowIndex * 100) / lines;
        }
        public bool IsPorcentInteger() => Porcent.ToString().ToCharArray().ToList().Exists(c => c == '.');
        public Notification() { }
        public Notification(double porcent, string message)
            : base(ibExeption: false, message: message) => Porcent = porcent;
        public Notification(double porcent, bool ibException, string message)
            : base(ibExeption: ibException, message: message) => Porcent = porcent;
        public Notification(double porcent, T value, int level = 1)
        {
            Porcent = porcent; Value = value; Level = level;
        }
        public Notification(int lines, int rowIndex, string message)
            : base(ibExeption: false, message: message) => SetPorcent(lines, rowIndex);
        public Notification(int lines, int rowIndex, bool ibException, string message)
            : base(ibExeption: ibException, message: message) => SetPorcent(lines, rowIndex);
        public Notification(int lines, int rowIndex, T value, int level = 1)
        {
            SetPorcent(lines, rowIndex);
            Value = value; Level = level;
        }
    }
}
