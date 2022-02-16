using System;
namespace ProblemaDiamente.Devices
{
    internal class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print + " +document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice processing + " + document);
        }

        public string Scan()
        {
            return "Combodevice scan result";
        }
    }
}
