using System;


namespace ReusoGenerics
{   

    //toda minha classe está associada ao tipo (T) Generics
    internal class PrintService<T>
    {
        //criado uma variavel interna que armazena até 10 valores
        private T[] _values = new T[10];
        private int _count = 0;

        public void addValue(T value)
        {
            if (_count == 10) throw new InvalidOperationException("PrintService is full");
            _values[_count] = value;
            _count++;
        }

        public T Frist()
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
