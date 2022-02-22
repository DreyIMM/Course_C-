using System;


namespace ReusoGenerics
{
    internal class PrintService
    {
        //criado uma variavel interna que armazena até 10 valores
        private object[] _values = new object[10];
        private int _count = 0;

        public void addValue(object value)
        {
            if (_count == 10) throw new InvalidOperationException("PrintService is full");
            _values[_count] = value;
            _count++;
        }

        public object Frist()
        {
            if (_count == 0) throw new InvalidOperationException("PrintService is empty");
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[ ");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }

            Console.Write("]");

        }





    }
}
